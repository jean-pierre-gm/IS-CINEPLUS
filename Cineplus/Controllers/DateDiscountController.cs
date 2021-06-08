using System;
using System.Collections.Generic;
using System.Linq;
using Cineplus.Models;
using Cineplus.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cineplus.Controllers {
    [Route("/api/[controller]")]
    public class DateDiscountController: Controller {
        private IDateDiscountService _dateDiscountService;
		
        public DateDiscountController(IDateDiscountService dateDiscountService) {
            _dateDiscountService = dateDiscountService;
        }
		
        [HttpGet]
        public ActionResult<Pagination<DateDiscount>> Index([FromQuery] Pagination<DateDiscount> parameters, 
            [FromQuery] bool admitDisabledDiscounts) {
            return new ActionResult<Pagination<DateDiscount>>(_dateDiscountService.GetAll(parameters, 
                admitDisabledDiscounts));
        }
        
        [Authorize(Roles = "Admin,Manager", AuthenticationSchemes = IdentityExtensions.AuthenticationScheme)]
        [HttpPut("{id:int}")]
        public ActionResult<DateDiscount> PutDateDiscount(int id, [FromBody]DateDiscount dateDiscount) {
            if (id != dateDiscount.Id) {
                return BadRequest();
            }
            
            if(_dateDiscountService.Get(dateDiscount.Id, false) is null)
                return NotFound();
            
            return _dateDiscountService.Update(dateDiscount);
        }

        [HttpPost]
        public ActionResult<DateDiscount> PostDateDiscount([FromBody] DateDiscount dateDiscount)
        {
            if(_dateDiscountService.GetforDate(dateDiscount.Date, false) is not null)
                return BadRequest();
            
            return _dateDiscountService.Add(dateDiscount);
        }
    }
}