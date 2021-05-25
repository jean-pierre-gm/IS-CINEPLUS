using System.Collections.Generic;
using System.Linq;
using Cineplus.Models;

namespace Cineplus.Services
{
    public class DateDiscountService : IDateDiscountService
    {
        private IRepository<DateDiscount> _repository;

        public DateDiscountService(IRepository<DateDiscount> repository)
        {
            _repository = repository;
        }

        public DateDiscount Get(int id)
        {
            return _repository.Data().FirstOrDefault(datediscount => datediscount.Id == id);
        }

        public IEnumerable<DateDiscount> GetAll()
        {
            return _repository.Data().AsEnumerable();
        }

        public DateDiscount Add(DateDiscount entity)
        {
            return _repository.Add(entity);
        }

        public DateDiscount Update(DateDiscount entity)
        {
            return _repository.Update(entity);
        }

        public DateDiscount Remove(int id)
        {
            return _repository.Remove(id);
        }
    }
}