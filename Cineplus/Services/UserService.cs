using System.Linq;
using System.Threading.Tasks;
using Cineplus.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Cineplus.Services {
	public class UserService: IUserService {

		private IHttpContextAccessor _httpContextAccessor;
		private UserManager<ApplicationUser> _userManager;
		public UserService(IHttpContextAccessor httpContextAccessor, UserManager<ApplicationUser> userManager) {
			_httpContextAccessor = httpContextAccessor;
			_userManager = userManager;
		}

		public async Task<ApplicationUser> GetCurrentUser() {
			var userName = _httpContextAccessor.HttpContext?.User.Identity?.Name;

			if (userName == null) {
				return null;
			}

			var user = await _userManager.Users
				.Include(u => u.Associate)
				.FirstOrDefaultAsync(u => u.UserName == userName);

			return user;
		}
	}
}