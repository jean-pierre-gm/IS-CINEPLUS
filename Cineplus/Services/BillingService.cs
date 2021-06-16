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

            switch (purchaseType)
            {
                case PurchaseType.Associate:
                    var pointsPrice = _ticketRepository.Data().Where(ticket => ticket.OrderId == order)
                        .Sum((ticket => ticket.PointsPrice));
                    var associateTask = _associateService.GetCurrentUserAssociate();
                    associateTask.Wait();
                    var associate = associateTask.Result;
                    if (associate == null || associate.Points < pointsPrice)
                    {
                        confirmation = Guid.Empty;
                        return false;
                    }

                    _associateService.RemovePoints(associate, (int) pointsPrice);
                    confirmation = Guid.NewGuid();
                    return true;

                case PurchaseType.User:
                case PurchaseType.Agent:
                    confirmation = Guid.NewGuid();
                    return true;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public bool RefundPurchase(Guid order)
        {
            return true;
        }
    }
}