using System.Collections.Generic;
using System.Linq;
using Cineplus.Models;
using Microsoft.EntityFrameworkCore;

namespace Cineplus.Services {
	public class MovieService: IMovieService {
		private IRepository<Movie> _movieRepository;
		public MovieService(IRepository<Movie> movieRepository) {
			_movieRepository = movieRepository;
		}

		public Movie Get(int id) {
			return _movieRepository.Data().Include(movie => movie.Genre).FirstOrDefault(movie => movie.Id == id);
		}

		public Pagination<Movie> GetAllWithGenre(Pagination<Movie> parameters) {
			return PaginationService.GetPagination(
				_movieRepository.Data().Include(movie => movie.Genre), parameters
			);
		}

		public IEnumerable<Movie> GetAll()
		{
			return _movieRepository.Data().AsEnumerable();
		}

		public Movie Add(Movie entity) {
			if (entity.Genre != null) {
				entity.GenreId = entity.Genre.Id;
				entity.Genre = null;
			}
			return _movieRepository.Add(entity);
		}

		public Movie Update(Movie entity) {
			return _movieRepository.Update(entity);
		}

		public Movie Remove(int id) {
			return _movieRepository.Remove(id);
		}
	}
}