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
        private readonly IRepository<DateDiscount> _dateDiscountRepository;
        private readonly IRepository<PersonalDiscount> _personalDiscountRepository;
        private readonly IBillingService _billingService;

        public TicketService(IRepository<Ticket> ticketRepository, IRepository<Seat> seatRepository,
            IRepository<Reproduction> reprodRepository, IRepository<DateDiscount> dateDiscountRepository,
            IRepository<PersonalDiscount> personalDiscountRepository, IBillingService billingService)
        {
            _ticketRepository = ticketRepository;
            _seatRepository = seatRepository;
            _reprodRepository = reprodRepository;
            _dateDiscountRepository = dateDiscountRepository;
            _personalDiscountRepository = personalDiscountRepository;
            _billingService = billingService;
        }

        private void _purge()
        {
            var dateTimeout = DateTime.Now.AddMinutes(-1);
            _ticketRepository.RemoveRange(_ticketRepository.Data()
                .Where(ticket => ticket.OrderId != Guid.Empty && ticket.Confirmation == Guid.Empty &&
                                 ticket.ReserveTime <= dateTimeout));
        }


        public ActionResult MakeOrder(Guid order, ApplicationUser user,bool assoc)
        {
            if (user == null)//check if associate
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
            var query = _ticketRepository.Data().Include(tick => tick.Reproduction).Include(tick => tick.Seat)
                .Include(tick => tick.Reproduction.Movie).Include(tick => tick.Seat.Theater)
                .Where(ticket => ticket.User == user && ticket.Confirmation != Guid.Empty).AsEnumerable()
                .GroupBy(ticket => ticket.OrderId).AsQueryable();
            return PaginationService.GetPagination(query, parameters);
        }


        public ActionResult CancelOrder(Guid orderid, ApplicationUser user)
        {
            if (user == null) return new BadRequestResult();
            var cancelable = _ticketRepository.Data().Include(ticket => ticket.Reproduction)
                .Where(ticket => ticket.User == user && ticket.Confirmation != Guid.Empty &&
                                 ticket.OrderId == orderid &&
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
                return new BadRequestResult();
        }

        public ActionResult MakeReserveForUser(List<Ticket> toReserve, ApplicationUser user)
        {
            _purge();
            List<Ticket> reserved = new List<Ticket>();

            //chekcuser

            if (user == null || !toReserve.Any()) return new BadRequestResult();

            Reproduction existentReproduction = null;
            foreach (var ticket in toReserve)
            {
                if (ticket.Seat == null)return new BadRequestResult();;
                var existentSeat = _seatRepository.Data().FirstOrDefault(s =>
                    s.TheaterId == ticket.Seat.TheaterId && s.Row == ticket.Seat.Row &&
                    s.Column == ticket.Seat.Column);
                if (existentSeat == null)return new BadRequestResult();;

                var sameReserve = _ticketRepository.Data()
                    .FirstOrDefault(t => t.ReproductionId == ticket.ReproductionId && t.Seat == existentSeat);
                if (sameReserve != null)return new BadRequestResult();;

                existentReproduction ??= _reprodRepository.Data()
                    .FirstOrDefault(r => r.Id == ticket.ReproductionId && r.TheaterId == existentSeat.TheaterId);
                
                if (existentReproduction == null || ticket.ReproductionId != existentReproduction.Id )return new BadRequestResult();;

                double totalDiscount = 0;
                DateDiscount existentDateDiscount = null;
                var existentpersonalDiscounts = new List<PersonalDiscount>();
                
                if (ticket.DateDiscount != null)
                {
                    existentDateDiscount = _dateDiscountRepository
                        .Data().FirstOrDefault(discount => discount.Enable && discount.Id == ticket.DateDiscount.Id);
                    if (existentDateDiscount == null)return new BadRequestResult();;
                    totalDiscount += existentDateDiscount.Discount;
                }

                if (ticket.PersonalDiscounts != null && ticket.PersonalDiscounts.Any())
                {
                    foreach (var disc in ticket.PersonalDiscounts)
                    {
                        var existentPersonalDiscount = _personalDiscountRepository
                            .Data().FirstOrDefault(discount =>
                                discount.Enable && discount.Id == disc.Id);
                        if (existentPersonalDiscount == null)return new BadRequestResult();;
                        existentpersonalDiscounts.Add(existentPersonalDiscount);
                        totalDiscount += existentPersonalDiscount.Discount;
                    }
                }
                
                totalDiscount = Math.Min(100, totalDiscount);
                double price = existentReproduction.Price - existentReproduction.Price * totalDiscount / 100;
              
                var newticket = new Ticket()
                {
                    PointsPrice = 20, //if asociate
                    Price = price,
                    User = user,
                    Seat = existentSeat,
                    Reproduction =existentReproduction,
                    DateDiscount = existentDateDiscount,
                    PersonalDiscounts = existentpersonalDiscounts,
                };
                reserved.Add(newticket);
                _ticketRepository.Add(newticket);
            }

            if (reserved.Any())
            {
                var orderGuid = Guid.NewGuid();
                foreach (var ticket in _ticketRepository.Data().Where(ticket =>
                    ticket.User == user && ticket.Confirmation == Guid.Empty &&
                    ticket.Reproduction == reserved.First().Reproduction))
                {
                    ticket.OrderId = orderGuid;
                    ticket.ReserveTime = DateTime.Now;
                    _ticketRepository.Update(ticket);
                }
            }

            return new OkResult();
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