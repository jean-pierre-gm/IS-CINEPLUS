using System;
using System.Linq;
using Cineplus.Models;

namespace Cineplus.Services
{
    public class BillingService : IBillingService
    {
        private readonly IRepository<Ticket> _ticketRepository;
        private readonly IAssociateService _associateService;

        public enum PurchaseType
        {
            User,
            Associate,
            Agent,
        }

        public BillingService(IRepository<Ticket> ticketRepository, IAssociateService associateService)
        {
            _ticketRepository = ticketRepository;
            _associateService = associateService;
        }

        public bool VerifyPurchase(Guid order, Enum type, out Guid confirmation)
        {
            if (type is not PurchaseType purchaseType)
            {
                confirmation = Guid.Empty;
                return false;
            }

            var associateTask = _associateService.GetCurrentUserAssociate();
            associateTask.Wait();
            var associate = associateTask.Result;
            switch (purchaseType)
            {
                case PurchaseType.Associate:
                    var pointsPrice = _ticketRepository.Data().Where(ticket => ticket.OrderId == order)
                        .Sum((ticket => ticket.PointsPrice));

                    if (associate == null || associate.Points < pointsPrice)
                    {
                        confirmation = Guid.Empty;
                        return false;
                    }

                    _associateService.RemovePoints(associate, (int) pointsPrice);
                    confirmation = Guid.NewGuid();
                    return true;

                case PurchaseType.User:
                    //contact billing api
                    var ticketsCount = _ticketRepository.Data().Count(ticket => ticket.OrderId == order);
                    //give bonus
                    if (associate != null)
                    {
                        _associateService.AddPoints(associate, ticketsCount * 5);
                    }

                    confirmation = Guid.NewGuid();
                    return true;
                case PurchaseType.Agent:
                    confirmation = Guid.NewGuid();
                    return true;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public bool RefundPurchase(Guid order)
        {
            var tickets = _ticketRepository.Data().Where(ticket => ticket.OrderId == order);
            var pointsEarned = tickets.Sum((ticket => ticket.PointsPrice));

            var associateTask = _associateService.GetCurrentUserAssociate();
            associateTask.Wait();
            var associate = associateTask.Result;
            //an order can only  be paid with one type of payment
            if (associate != null)
            {
                if (pointsEarned != 0)
                {
                    _associateService.AddPoints(associate, (int) pointsEarned);
                }
                else
                {
                    //get back the bonus points
                    _associateService.RemovePoints(associate, (int) tickets.Count() * 5);
                }
            }

            //contact billing api
            return true;
        }
    }
}