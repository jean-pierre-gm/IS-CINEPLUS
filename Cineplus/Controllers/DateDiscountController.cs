using System;
using System.Collections.Generic;
using System.Linq;
using Cineplus.Models;
using Cineplus.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cineplus.Controllers {
    [Route("/api/[controller]")]
    public class DateDiscountController: Controller {
        private IDateDiscountService _dateDiscountService;
		
        public DateDiscountController(IDateDiscountService dateDiscountService) {
            _dateDiscountService = dateDiscountService;
        }
		
        [HttpGet]
        public ActionResult<Pagination<DateDiscount>> Index([FromQuery] Pagination<DateDiscount> parameters) {
            return new ActionResult<Pagination<DateDiscount>>(_dateDiscountService.GetAll(parameters));
        }

        [HttpPost]
        public ActionResult<DateDiscount> PostDateDiscount([FromBody]DateDiscount dateDiscount) {
            if(_dateDiscountService.Get(dateDiscount.Id) is null)
                _dateDiscountService.Add(dateDiscount);

            else
                _dateDiscountService.Update(dateDiscount);

            return new ActionResult<DateDiscount>(dateDiscount);
        }
        
        [HttpDelete]
        public ActionResult<DateDiscount> DeleteDateDiscount([FromQuery]string id)
        {
            int Id;

            if (id == null || !int.TryParse(id, out Id)) {
                return NotFound();
            }

            var removed = _dateDiscountService.Remove(Id);

            if (removed == null) {
                return NotFound();
            }

            return removed;
        }
        
    }
}