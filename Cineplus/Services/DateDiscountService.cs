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

        public Pagination<DateDiscount> GetAll(Pagination<DateDiscount> parameters)
        {
            return PaginationService.GetPagination(
                _dateDiscountRepository.Data().AsQueryable(),
                parameters.CurrentPage,
                parameters.OrderBy,
                parameters.OrderByDesc,
                parameters.PageSize);
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