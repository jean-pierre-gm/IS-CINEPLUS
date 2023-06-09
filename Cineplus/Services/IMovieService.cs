using System.Collections;
using System.Collections.Generic;
using Cineplus.Models;

namespace Cineplus.Services {
	public interface IMovieService {
		Movie Get(int id);
		Pagination<Movie> GetAllWithGenre(Pagination<Movie> parameters);
		Pagination<Movie> GetPaginationDisplay(string name, Pagination<Movie> parameters);
		IEnumerable<Movie> SetManualDisplay(IEnumerable<Movie> movies);
		Movie Add(Movie entity);
		Movie Update(Movie entity);
		Movie Remove(int id);
	}
}