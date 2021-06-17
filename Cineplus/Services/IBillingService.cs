using System;

namespace Cineplus.Services
{
    public interface IBillingService
    {
        bool VerifyPurchase(Guid order,out Guid confirmation);
        
        bool RefundPurchase(Guid order);
    }
}