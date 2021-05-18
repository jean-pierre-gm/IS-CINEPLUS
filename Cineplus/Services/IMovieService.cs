using System.Collections.Generic;
using Cineplus.Models;

namespace Cineplus.Services {
	public interface IMovieService {
		Movie Get(int id);
		Pagination<Movie> GetAllWithGenre(Pagination<Movie> parameters);
		Movie Add(Movie entity);
		Movie Update(Movie entity);
		Movie Remove(int id);
	}
}