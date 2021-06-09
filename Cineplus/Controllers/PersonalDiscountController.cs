using System;
using System.Collections.Generic;
using System.Linq;
using Cineplus.Models;
using Cineplus.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cineplus.Controllers {
    [Route("/api/[controller]")]
    public class PersonalDiscountController: Controller {
        private IPersonalDiscountService _personalDiscountService;
		
        public PersonalDiscountController(IPersonalDiscountService personalDiscountService) {
            _personalDiscountService = personalDiscountService;
        }
		
        [HttpGet]
        public ActionResult<Pagination<PersonalDiscount>> Index([FromQuery] Pagination<PersonalDiscount> parameters, 
            [FromQuery] bool admitDisabledDiscounts) {
            return new ActionResult<Pagination<PersonalDiscount>>(_personalDiscountService.GetAll(parameters, 
                admitDisabledDiscounts));
        }
        
        [Authorize(Roles = "Admin,Manager", AuthenticationSchemes = IdentityExtensions.AuthenticationScheme)]
        [HttpPut("{id:int}")]
        public ActionResult<PersonalDiscount> PutPersonalDiscount(int id, [FromBody]PersonalDiscount personalDiscount) {
            if (id != personalDiscount.Id) {
                return BadRequest();
            }
            
            if(_personalDiscountService.Get(personalDiscount.Id, false) is null)
                return NotFound();
            
            return _personalDiscountService.Update(personalDiscount);
        }
        
        [Authorize(Roles = "Admin,Manager", AuthenticationSchemes = IdentityExtensions.AuthenticationScheme)]
        [HttpPost]
        public ActionResult<PersonalDiscount> PostPersonalDiscount([FromBody] PersonalDiscount personalDiscount)
        {
            return _personalDiscountService.Add(personalDiscount);
        }
    }
}