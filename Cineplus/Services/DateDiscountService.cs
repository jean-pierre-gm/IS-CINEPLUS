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
        
        public DateDiscount GetforDate(int day, int month, int year, bool tracked = true)
        {
            return _dateDiscountRepository.Data(tracked).FirstOrDefault(dateDiscount => 
                dateDiscount.Date.Day == day && dateDiscount.Date.Month == month &&
                dateDiscount.Date.Year == year);
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