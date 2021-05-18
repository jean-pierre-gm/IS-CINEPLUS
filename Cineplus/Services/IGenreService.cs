using System.Collections.Generic;
using Cineplus.Models;

namespace Cineplus.Services {
	public interface IGenreService {
		Genre Get(int id);
		IEnumerable<Genre> GetAll();
		Genre Add(Genre entity);
		Genre Update(Genre entity);
		Genre Remove(int id);
	}
}