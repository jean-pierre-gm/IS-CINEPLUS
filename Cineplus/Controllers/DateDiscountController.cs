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
        
        [HttpPut]
        public ActionResult<DateDiscount> PutDateDiscount([FromBody]DateDiscount dateDiscount) {
            if(_dateDiscountService.Get(dateDiscount.Id, false) is null)
                return NotFound();
            
            _dateDiscountService.Update(dateDiscount);

            return new ActionResult<DateDiscount>(dateDiscount);
        }

        [HttpPost]
        public ActionResult<DateDiscount> PostDateDiscount([FromBody] DateDiscount dateDiscount)
        {
            if (_dateDiscountService.Get(dateDiscount.Id, false) is not null)
                return BadRequest();

            _dateDiscountService.Add(dateDiscount);

            return new ActionResult<DateDiscount>(dateDiscount);
        }
    }
}