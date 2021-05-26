using System.Collections.Generic;
using Cineplus.Models;

namespace Cineplus.Services
{
    public interface IDateDiscountService
    {
        DateDiscount Get(int id);
        Pagination<DateDiscount> GetAll(Pagination<DateDiscount> parameters);
        DateDiscount Add(DateDiscount entity);
        DateDiscount Update(DateDiscount entity);
        DateDiscount Remove(int id);
    }
}