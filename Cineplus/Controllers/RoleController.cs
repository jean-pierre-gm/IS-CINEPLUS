using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Cineplus.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cineplus.Controllers {
	[Authorize(Roles = "Admin", AuthenticationSchemes = IdentityExtensions.AuthenticationScheme)]
	[Route("/api/[controller]")]
	public class RoleController : Controller {
		
		private RoleManager<IdentityRole> _roleManager;
		private UserManager<ApplicationUser> _userManager;
		public RoleController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager) {
			_roleManager = roleManager;
			_userManager = userManager;
		}
		
		[HttpGet]
		public ActionResult<IEnumerable<IdentityRole>> GetRoles() {
			return new(_roleManager.Roles.AsEnumerable<IdentityRole>());
		}

		[HttpPost("{roleName}")]
		public async Task<ActionResult<ApplicationUser>> AddOrRemoveUserRole(string roleName, [FromQuery] string userId) {
			if (userId == null) {
				return NotFound();
			}

			var user = await _userManager.FindByIdAsync(userId);

			if (user == null) {
				return NotFound();
			}

			IdentityResult response;

			if (await _userManager.IsInRoleAsync(user, roleName)) {
				response = await _userManager.RemoveFromRoleAsync(user, roleName);
			}
			else {
				response = await _userManager.AddToRoleAsync(user, roleName);
			}

			if (response.Succeeded) {
				return user;
			}

			return NotFound();
		}
	}
}