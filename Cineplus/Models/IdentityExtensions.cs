using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace Cineplus.Models {
	public static class IdentityExtensions {

		public const string AuthenticationScheme = "Identity.Application";
		
		public static async void SeedIdentity(
			UserManager<ApplicationUser> userManager,
			RoleManager<IdentityRole> roleManager,
			IConfiguration configuration) {

			var roles = configuration["Roles"].Split(",");

			foreach (var roleName in roles) {
				var role = await roleManager.FindByNameAsync(roleName);
				if (role == null) {
					role = new IdentityRole(roleName);
					await roleManager.CreateAsync(role);
				}
			}

			var users = new (string, string)[] {
				("AdminUser", "Admin"),
				("CustomerUser", "Customer"),
				("TicketAgentUser", "TicketAgent"),
				("ManagerUser", "Manager")
			};
			
			foreach (var userString in users) {
				
				var username = configuration[$"{userString.Item1}:UserName"];
				var email = configuration[$"{userString.Item1}:Email"];
				var password = configuration[$"{userString.Item1}:Password"];
				

				var dbUser = await userManager.FindByEmailAsync(email);
				
				if (dbUser != null) {
					continue;
				}
				
				
				var user = new ApplicationUser {UserName = username, Email = email, EmailConfirmed = true};
				await userManager.CreateAsync(user, password);
			
				await userManager.AddToRoleAsync(user, userString.Item2);
			}
		}
	}
}