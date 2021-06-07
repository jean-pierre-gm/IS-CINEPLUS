using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cineplus.Models;
using Cineplus.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Cineplus.Controllers {
	[Authorize(Roles = "Admin", AuthenticationSchemes = IdentityExtensions.AuthenticationScheme)]
	[Route("/api/[controller]")]
	public class UserController : Controller {

		private UserManager<ApplicationUser> _userManager;
		public UserController(UserManager<ApplicationUser> userManager) {
			_userManager = userManager;
		}

		[HttpGet]
		public async Task<ActionResult<Pagination<ApplicationUser>>> GetUsers([FromQuery] Pagination<ApplicationUser> pagination) {
			var page = PaginationService.GetPagination((IQueryable<ApplicationUser>)_userManager.Users, pagination);
			foreach (var applicationUser in page.Result) {
				applicationUser.Roles = await _userManager.GetRolesAsync(applicationUser);
			}
			return new ActionResult<Pagination<ApplicationUser>>(page);
		}
	}
}