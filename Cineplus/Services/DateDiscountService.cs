﻿using System;
using System.Collections.Generic;
using System.Linq;
using Cineplus.Models;

namespace Cineplus.Services
{
    public class DateDiscountService : IDateDiscountService
    {
        private IRepository<DateDiscount> _dateDiscountRepository;

        public DateDiscountService(IRepository<DateDiscount> repository)
        {
            _dateDiscountRepository = repository;
        }

        public DateDiscount Get(int id, bool tracked = true)
        {
            return _dateDiscountRepository.Data(tracked).FirstOrDefault(dateDiscount => dateDiscount.Id == id);
        }
        
        public DateDiscount GetforDate(DateTime date, bool tracked = true)
        {
            return _dateDiscountRepository.Data().FirstOrDefault(dateDiscount => 
                dateDiscount.Date.Day == date.Day && dateDiscount.Date.Month == date.Month);
        }

        public Pagination<DateDiscount> GetAll(Pagination<DateDiscount> parameters, bool admitDisabledDiscounts)
        {
            return PaginationService.GetPagination(
                (admitDisabledDiscounts) ?
                _dateDiscountRepository.Data().AsQueryable() :
                _dateDiscountRepository.Data().Where(discount => discount.Enable).AsQueryable(), parameters);
        }

        public DateDiscount Add(DateDiscount entity)
        {
            return _dateDiscountRepository.Add(entity);
        }

        public DateDiscount Update(DateDiscount entity)
        {
            return _dateDiscountRepository.Update(entity);
        }
    }
}