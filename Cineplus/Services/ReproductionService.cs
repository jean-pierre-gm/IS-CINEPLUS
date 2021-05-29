using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cineplus.Models;
using Microsoft.EntityFrameworkCore;

namespace Cineplus.Services {
	public class ReproductionService: IReproductionService {
		private IRepository<Reproduction> _repository;
		public ReproductionService(IRepository<Reproduction> repository) {
			_repository = repository;
		}

		public Reproduction Get(int id) {
			return _repository.Data().Include(reproduction => reproduction.Movie)
				.FirstOrDefault(r => r.Id == id);
		}

		public Pagination<Reproduction> GetAllAtDay(DateTime dateTime, Pagination<Reproduction> parameters) {
			return PaginationService.GetPagination(
				_repository.Data().Include(reproduction => reproduction.Movie)
					.Where(reproduction => reproduction.StartTime.Date == dateTime.Date),
				parameters.CurrentPage,
				parameters.OrderBy,
				parameters.OrderByDesc,
				parameters.PageSize);
		}

		public Pagination<Reproduction> GetAllOfMovie(int movieId, Pagination<Reproduction> parameters) {
			return PaginationService.GetPagination(
					_repository.Data().Include(reproduction => reproduction.Movie)
						.Where(reproduction => reproduction.MovieId == movieId),
				parameters.CurrentPage,
				parameters.OrderBy,
				parameters.OrderByDesc,
				parameters.PageSize);
		}

		public Reproduction Add(Reproduction entity) {
			bool mark = false;
			
			if (entity.Theater != null) {
				entity.TheaterId = entity.Theater.Id;
				entity.Theater = null;
			}
			
			if (entity.Movie != null)
			{
				mark = true;
				int peek = _repository.Data().Include(
						reproduction => reproduction.Movie)
							.Count(reproduction => reproduction.TheaterId == entity.TheaterId &&
							                       (reproduction.StartTime.AddMinutes(reproduction.Movie.Duration) > entity.StartTime &&
												    entity.StartTime > reproduction.StartTime) || 
							                       (reproduction.StartTime > entity.StartTime &&
													entity.StartTime.AddMinutes(entity.Movie.Duration) > reproduction.StartTime));
				if (peek != 0)
					return null;
				entity.MovieId = entity.Movie.Id;
				entity.Movie = null;
			}

			if (!mark)
			{
				int check = _repository.Data().Include(
						reproduction => reproduction.Movie)
					.Count(reproduction => reproduction.TheaterId == entity.TheaterId &&
					                       reproduction.StartTime.AddMinutes(reproduction.Movie.Duration) >
					                       entity.StartTime &&
					                       entity.StartTime > reproduction.StartTime);
				if (check != 0)
					return null;
			}

			return _repository.Add(entity);
		}

		public Reproduction Update(Reproduction entity) {
			return _repository.Update(entity);
		}

		public Reproduction Remove(int id) {
			return _repository.Remove(id);
		}

		public Pagination<Reproduction> GetAll(Pagination<Reproduction> parameters) {
			return PaginationService.GetPagination(
				_repository.Data().Include(reproduction => reproduction.Movie),
				parameters.CurrentPage,
				parameters.OrderBy,
				parameters.OrderByDesc,
				parameters.PageSize);
		}
	}
}