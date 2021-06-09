using System.Collections.Generic;
using Cineplus.Models;

namespace Cineplus.Services
{
    public interface IPersonalDiscountService
    {
        PersonalDiscount Get(int id, bool tracked = true);
        Pagination<PersonalDiscount> GetAll(Pagination<PersonalDiscount> parameters, bool admitDisabledDiscounts);
        PersonalDiscount Add(PersonalDiscount entity);
        PersonalDiscount Update(PersonalDiscount entity);
    }
}