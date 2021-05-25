using System;
using System.Collections.Generic;
using System.Linq;
using Cineplus.Models;
using Cineplus.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cineplus.Controllers {
    [Route("/api/[controller]")]
    public class DateDiscountController: Controller {
        private IDateDiscountService _datediscountService;
		
        public DateDiscountController(IDateDiscountService datediscountService) {
            _datediscountService = datediscountService;
        }
		
        [HttpGet]
        public ActionResult<IEnumerable<DateDiscount>> Index() {
            return new ActionResult<IEnumerable<DateDiscount>>(_datediscountService.GetAll());
        }

        [HttpPost]
        public ActionResult<DateDiscount> PostMovie([FromBody]DateDiscount datediscount) {
            _datediscountService.Add(datediscount);
            return new ActionResult<DateDiscount>(datediscount);
        }
    }
}