using System.Collections.Generic;
using Cineplus.Models;

namespace Cineplus.Services
{
    public interface IDateDiscountService
    {
        DateDiscount Get(int id);
        IEnumerable<DateDiscount> GetAll();
        DateDiscount Add(DateDiscount entity);
        DateDiscount Update(DateDiscount entity);
        DateDiscount Remove(int id);
    }
}