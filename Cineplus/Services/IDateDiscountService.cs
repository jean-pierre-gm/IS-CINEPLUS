﻿using System;
using System.Collections.Generic;
using Cineplus.Models;

namespace Cineplus.Services
{
    public interface IDateDiscountService
    {
        DateDiscount Get(int id, bool tracked = true);
        DateDiscount GetforDate(DateTime date, bool tracked = true);
        Pagination<DateDiscount> GetAll(Pagination<DateDiscount> parameters, bool admitDisabledDiscounts);
        DateDiscount Add(DateDiscount entity);
        DateDiscount Update(DateDiscount entity);
    }
}