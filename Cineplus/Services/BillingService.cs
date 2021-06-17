using System;

namespace Cineplus.Services
{
    public class BillingService : IBillingService
    {
        public bool VerifyPurchase(Guid order,out Guid confirmation)
        {
            confirmation=  Guid.NewGuid();
            return true;
        }

        public bool RefundPurchase(Guid order)
        {
            
            return true;
        }
    }
}