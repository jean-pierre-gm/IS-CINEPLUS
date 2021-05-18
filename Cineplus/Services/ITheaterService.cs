using System.Collections.Generic;
using Cineplus.Models;

namespace Cineplus.Services {
	public interface ITheaterService {
		Theater Get(int id);
		IEnumerable<Theater> GetAll();
		Theater Add(Theater entity);
		Theater Update(Theater entity);
		Theater Remove(int id);
	}
}