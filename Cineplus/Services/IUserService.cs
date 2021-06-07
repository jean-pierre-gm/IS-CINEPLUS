using System.Threading.Tasks;
using AutoMapper.Configuration.Annotations;
using Cineplus.Models;

namespace Cineplus.Services {
	public interface IUserService {
		public Task<ApplicationUser> GetCurrentUser();
	}
}