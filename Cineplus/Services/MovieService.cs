using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cineplus.Models;
using Microsoft.EntityFrameworkCore;

namespace Cineplus.Services {
	public class MovieService: IMovieService {
		private IRepository<Movie> _movieRepository;
		private ISettingsService _settingsService;
		public MovieService(IRepository<Movie> movieRepository, ISettingsService settingsService) {
			_movieRepository = movieRepository;
			_settingsService = settingsService;
		}

		public Movie Get(int id) {
			return _movieRepository.Data().Include(movie => movie.Genre).FirstOrDefault(movie => movie.Id == id);
		}

		public Pagination<Movie> GetAllWithGenre(Pagination<Movie> parameters) {
			return PaginationService.GetPagination(
				_movieRepository.Data().Include(movie => movie.Genre), parameters
			);
		}

		private IQueryable<Movie> GetDisplay(string name)
		{
			IQueryable<Movie> data = _movieRepository.Data().Include(movie => movie.Genre);
			if(name == "Best Reviews")
				return data.OrderByDescending(movie => movie.Score).Take(10);
			if (name == "Manual")
				return data.OrderByDescending(movie => movie.Display).Take(10);
			if (name == "Random")
				return data.OrderBy(movie => new Random().NextDouble()).Take(10);
			if (name == "Most seen")
				return null;
			return null;
		}

		public Pagination<Movie> GetPaginationDisplay(Pagination<Movie> parameters)
		{
			Settings active = _settingsService.GetActiveDisplay();
			IQueryable<Movie> query = GetDisplay(active.Name);
			return PaginationService.GetPagination(query, parameters);
		}

		public IEnumerable<Movie> GetAllDisplay(string name)
		{
			if(name == "" || name is null)
				name = _settingsService.GetActiveDisplay().Name;
			return GetDisplay(name).AsEnumerable();
		}

		public IEnumerable<Movie> SetManualDisplay(IEnumerable<Movie> movies)
		{
			DateTime now = DateTime.Now;
			var moviesList = new List<Movie>(movies);

			for (int i = 0; i < moviesList.Count; i++)
			{
				moviesList[i].Display = now;
				moviesList[i].Genre = null;
			}

			_movieRepository.UpdateAll(moviesList);
			
			return moviesList;
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