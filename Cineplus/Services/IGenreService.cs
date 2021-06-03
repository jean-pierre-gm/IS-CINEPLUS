using System.Collections.Generic;
using Cineplus.Models;

namespace Cineplus.Services {
	public interface IGenreService {
		Genre Get(int id);
		Pagination<Genre> GetAll(Pagination<Genre> pagination);
		Genre Add(Genre entity);
		Genre Update(Genre entity);
		Genre Remove(int id);
	}
}