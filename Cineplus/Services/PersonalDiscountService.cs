using System.Collections.Generic;
using System.Linq;
using Cineplus.Models;

namespace Cineplus.Services
{
    public class PersonalDiscountService : IPersonalDiscountService
    {
        private IRepository<PersonalDiscount> _personalDiscountRepository;

        public PersonalDiscountService(IRepository<PersonalDiscount> repository)
        {
            _personalDiscountRepository = repository;
        }

        public PersonalDiscount Get(int id, bool tracked = true)
        {
            return _personalDiscountRepository.Data(tracked).
                FirstOrDefault(personalDiscount => personalDiscount.Id == id);
        }

        public Pagination<PersonalDiscount> GetAll(Pagination<PersonalDiscount> parameters, bool admitDisabledDiscounts) {
            return PaginationService.GetPagination(
                (admitDisabledDiscounts)
                    ? _personalDiscountRepository.Data().AsQueryable()
                    : _personalDiscountRepository.Data().Where(discount => discount.Enable).AsQueryable(), parameters);
        }

        public PersonalDiscount Add(PersonalDiscount entity)
        {
            return _personalDiscountRepository.Add(entity);
        }

        public PersonalDiscount Update(PersonalDiscount entity)
        {
            return _personalDiscountRepository.Update(entity);
        }
    }
}