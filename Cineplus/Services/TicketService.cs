using System;
using System.Collections.Generic;
using System.Linq;
using Cineplus.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cineplus.Services
{
    public class TicketService : ITicketService
    {
        private readonly IRepository<Ticket> _ticketRepository;
        private readonly IRepository<Seat> _seatRepository;
        private readonly IRepository<Reproduction> _reprodRepository;
        private readonly IBillingService _billingService;

        public TicketService(IRepository<Ticket> ticketRepository, IRepository<Seat> seatRepository,
            IRepository<Reproduction> reprodRepository, IBillingService billingService)
        {
            _ticketRepository = ticketRepository;
            _seatRepository = seatRepository;
            _reprodRepository = reprodRepository;
            _billingService = billingService;
        }

        private void _purge()
        {
            var dateTimeout = DateTime.Now.AddMinutes(-1);
            _ticketRepository.RemoveRange(_ticketRepository.Data()
                .Where(ticket => ticket.OrderId != Guid.Empty && ticket.Confirmation == Guid.Empty &&
                                 ticket.ReserveTime <= dateTimeout));
        }


        public ActionResult MakeOrder(Guid order, ApplicationUser user)
        {
            if (user == null)
            {
                return new BadRequestResult();
            }

            var tickets = _ticketRepository.Data().Where(ticket =>
                ticket.User == user && ticket.Confirmation == Guid.Empty && ticket.OrderId == order).ToArray();
            if (tickets.Any() && _billingService.VerifyPurchase(order, out var confirmation))
            {
                foreach (var ticket in tickets)
                {
                    ticket.Confirmation = confirmation;
                    _ticketRepository.Update(ticket);
                }

                return new OkResult();
            }
            return new BadRequestResult();
        }

        public Pagination<IGrouping<Guid, Ticket>> PaginatedOrders(Pagination<IGrouping<Guid, Ticket>> parameters,
            ApplicationUser user)
        {
            var query = _ticketRepository.Data().Include(tick => tick.Reproduction).Include(tick => tick.Seat).Include(tick => tick.Reproduction.Movie)
                .Where(ticket => ticket.User == user && ticket.Confirmation != Guid.Empty).AsEnumerable()
                .GroupBy(ticket => ticket.OrderId).AsQueryable();
            return PaginationService.GetPagination(query, parameters);
        }


        public ActionResult CancelOrder(Guid orderid, ApplicationUser user)
        {
            if (user == null) return new BadRequestResult();
            var cancelable = _ticketRepository.Data().Include(ticket => ticket.Reproduction)
                .Where(ticket => ticket.User == user && ticket.Confirmation != Guid.Empty && ticket.OrderId == orderid &&
                                 ticket.Reproduction.StartTime < DateTime.Now.AddHours(-2));
            if (cancelable.Any() && _billingService.RefundPurchase(orderid))
            {
                _ticketRepository.RemoveRange(cancelable);
                return new OkResult();
            }
            else
            {
                return new BadRequestResult();
            }
        }


        public ActionResult CancelReserve(int ticketId, ApplicationUser user)
        {
            var cancelable = _ticketRepository.Data()
                .FirstOrDefault(ticket =>
                    ticket.User == user && ticket.Id == ticketId && ticket.Confirmation == Guid.Empty);
            if (cancelable != null)
            {
                _ticketRepository.Remove(cancelable.Id);
                return new OkResult();
            }
            else
            {
                return new BadRequestResult();
            }
        }

        public IEnumerable<Ticket> MakeReserveForUser(List<Ticket> toReserve, ApplicationUser user)
        {
            _purge();
            List<Ticket> reserved = new List<Ticket>();

            //chekcuser

            if (user == null || !toReserve.Any()) return reserved;

            foreach (var ticket in toReserve)
            {
                var ticketSeat = ticket.Seat;
                var existentSeat = _seatRepository.Data().FirstOrDefault(s =>
                    s.TheaterId == ticketSeat.TheaterId && s.Row == ticketSeat.Row &&
                    s.Column == ticketSeat.Column);
                if (existentSeat == null) continue;
                var sameReserve = _ticketRepository.Data()
                    .FirstOrDefault(t => t.ReproductionId == ticket.ReproductionId && t.Seat == existentSeat);
                if (sameReserve != null) continue;

                var reproduction = _reprodRepository.Data()
                    .FirstOrDefault(r => r.Id == ticket.ReproductionId && r.TheaterId == existentSeat.TheaterId);

                if (reproduction == null) continue;

                //Verificar los descuentos

                ticket.Id = 0;
                ticket.Price = reproduction.Price;
                ticket.ReserveTime = DateTime.Now;
                ticket.User = user;
                reserved.Add(ticket);
                _ticketRepository.Add(ticket);
            }

            if (reserved.Any())
            {
                var orderGuid = Guid.NewGuid();
                foreach (var ticket in _ticketRepository.Data().Where(ticket =>
                    ticket.User == user && ticket.Confirmation == Guid.Empty &&
                    ticket.Reproduction == toReserve.First().Reproduction))
                {
                    ticket.OrderId = orderGuid;
                    _ticketRepository.Update(ticket);
                }
            }

            return reserved;
        }


        public IEnumerable<Seat> GetAllReservedSeatsForReproduction(int reproductionId)
        {
            _purge();
            return _ticketRepository.Data().Include(ticket => ticket.Seat)
                .Where(ticket => ticket.ReproductionId == reproductionId).Select((s) => s.Seat).AsEnumerable();
        }

        public IEnumerable<Ticket> GetAllTicketsForUserAtReproduction(ApplicationUser user, int reproductionId,
            bool purchased = false)
        {
            _purge();
            if (user == null)
            {
                return Array.Empty<Ticket>();
            }

            Func<Ticket, bool> query = purchased
                ? ticket => ticket.Confirmation != Guid.Empty && ticket.ReproductionId == reproductionId &&
                            ticket.UserId == user.Id
                : ticket => ticket.Confirmation == Guid.Empty && ticket.ReproductionId == reproductionId &&
                            ticket.UserId == user.Id;

            return _ticketRepository.Data().Include(ticket => ticket.Seat)
                .Where(query).AsEnumerable();
        }

        public IQueryable<GroupByCount> GetMovieIdWithTicketsCount()
        {
            _purge();
            return _ticketRepository.Data()
                .Include(t => t.Reproduction)
                .GroupBy(t => t.Reproduction.MovieId)
                .Select(g => new GroupByCount() {Key = g.Key, Count = g.Count()});
        }
    }
}