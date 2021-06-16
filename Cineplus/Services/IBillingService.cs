using System;

namespace Cineplus.Services
{
    public interface IBillingService
    {
       
        bool VerifyPurchase(Guid order,Enum type,out Guid confirmation);
        
        bool RefundPurchase(Guid order);
    }
}