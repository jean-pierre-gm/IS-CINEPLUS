using System;
using Cineplus.Models;

namespace Cineplus.Services
{
    public interface IBillingService
    {
       
        bool VerifyPurchase(Guid order,Enum type,ApplicationUser user,out Guid confirmation);
        
        bool RefundPurchase(Guid order,ApplicationUser user);
    }
}