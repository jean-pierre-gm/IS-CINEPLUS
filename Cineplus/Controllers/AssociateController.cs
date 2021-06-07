using System;
using System.Threading.Tasks;
using Cineplus.Models;
using Cineplus.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Cineplus.Controllers {
	[Route("/api/[controller]")]
	public class AssociateController : Controller {

		private IAssociateService _associateService;
		public AssociateController(IAssociateService associateService) {
			_associateService = associateService;
		}

		[HttpGet]
		public async Task<ActionResult<Associate>> GetAssociate() {
			return await _associateService.GetCurrentUserAssociate();
		}

		[Authorize]
		[HttpPut]
		public async Task<ActionResult<Associate>> BecomeAssociate([FromBody] Associate associate) {
			Associate createdAssociate = await _associateService.Add(associate);

			if (createdAssociate == null) {
				return BadRequest();
			}
			
			return createdAssociate;
		}
	}
}