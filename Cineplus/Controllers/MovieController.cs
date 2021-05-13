using System;
using System.Collections.Generic;
using System.Linq;
using Cineplus.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cineplus.Controllers {
	[Route("/api/[controller]")]
	public class MovieController : Controller {

		private IRepository<Movie> _movieRepository;
		private IRepository<Genre> _genreRepository;
		
		public MovieController(IRepository<Movie> movieRepository, IRepository<Genre> genreRepository) {
			_movieRepository = movieRepository;
			_genreRepository = genreRepository;
		}

		[HttpGet]
		public ActionResult<IEnumerable<Movie>> Index() {
			IList<Movie> movies = new List<Movie>();
			foreach (var movie in _movieRepository.GetAll()) {
				movie.Genre = _genreRepository.Get(movie.GenreId);
				movies.Add(movie);
			}

			return new ActionResult<IEnumerable<Movie>>(movies);
		}

		[HttpGet("id")]
		public ActionResult<Movie> GetMovie(int id) {
			return _movieRepository.Get(id);
		}

		[HttpPost]
		public ActionResult<Movie> PostMovie([FromBody]Movie movie) {
			if (movie.Genre == null) {
				movie.Genre = _genreRepository.Get(movie.GenreId);
			} else {
				movie.Genre = _genreRepository.Get(movie.Genre.Id);
				movie.GenreId = movie.Genre.Id;
			}
			_movieRepository.Add(movie);
			return new ActionResult<Movie>(movie);
		}
	}
}