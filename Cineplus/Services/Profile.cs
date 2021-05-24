using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Cineplus.Models;
using IdentityModel;
using IdentityServer4.Models;
using IdentityServer4.Services;
using Microsoft.AspNetCore.Identity;

namespace Cineplus.Services {
	public class ProfileService : IProfileService
	{
		protected readonly UserManager<ApplicationUser> _userManager;


		public ProfileService(UserManager<ApplicationUser> userManager)
		{
			_userManager = userManager;
		}

		public async Task GetProfileDataAsync(ProfileDataRequestContext context)
		{
			ApplicationUser user = await _userManager.GetUserAsync(context.Subject);

			IList<string> roles = await _userManager.GetRolesAsync(user);

			IList<Claim> roleClaims = new List<Claim>();
			foreach (string role in roles)
			{
				roleClaims.Add(new Claim(JwtClaimTypes.Role, role));
			}

			//add user claims

			roleClaims.Add(new Claim(JwtClaimTypes.Name, user.UserName));
			context.IssuedClaims.AddRange(roleClaims);
		}

		public Task IsActiveAsync(IsActiveContext context)
		{
			return Task.CompletedTask;
		}
	}
}