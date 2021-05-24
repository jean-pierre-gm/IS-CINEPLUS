using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace Cineplus.Models {
	public static class IdentityExtensions {
		public static async void SeedIdentity(
			UserManager<ApplicationUser> userManager,
			RoleManager<IdentityRole> roleManager,
			IConfiguration configuration) {

			var username = configuration["AdminUser:UserName"];
			var email = configuration["AdminUser:Email"];
			var password = configuration["AdminUser:Password"];

			var dbUser = await userManager.FindByEmailAsync(email);
			
			if (dbUser != null) {
				return;
			}
			
			var user = new ApplicationUser {UserName = username, Email = email, EmailConfirmed = true};
			await userManager.CreateAsync(user, password);

			var role = new IdentityRole {Name = "Admin"};
			await roleManager.CreateAsync(role);

			await userManager.AddToRoleAsync(user, "Admin");
		}
	}
}