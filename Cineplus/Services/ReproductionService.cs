using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using Cineplus.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Cineplus.Services {
	public class ReproductionService: IReproductionService {
		private IRepository<Reproduction> _repository;
		private IRepository<Ticket> _ticketRepo;
		public ReproductionService(IRepository<Reproduction> repository, IRepository<Ticket> ticketRepo) {
			_repository = repository;
			_ticketRepo = ticketRepo;
		}

		public Reproduction Get(int id) {
			return _repository.Data().Include(reproduction => reproduction.Movie)
				.FirstOrDefault(r => r.Id == id);
		}

		public Pagination<Reproduction> GetAllAtDay(DateTime dateTime, Pagination<Reproduction> parameters) {
			return PaginationService.GetPagination(
				_repository.Data().Include(reproduction => reproduction.Movie)
					.Where(reproduction => reproduction.StartTime.Date == dateTime.Date), parameters);
		}

		public Pagination<Reproduction> GetAllOfMovie(int movieId, Pagination<Reproduction> parameters) {
			return PaginationService.GetPagination(
					_repository.Data().Include(reproduction => reproduction.Movie)
						.Where(reproduction => reproduction.MovieId == movieId), parameters);
		}

		public Pagination<Reproduction> GetAllOfMovieFromNow(int movieId, Pagination<Reproduction> parameters)
		{
			return PaginationService.GetPagination(
					_repository.Data().Include(reproduction => reproduction.Movie)
						.Where(reproduction => reproduction.MovieId == movieId && reproduction.StartTime >= DateTime.Now)
						.OrderBy(reproduction => reproduction.StartTime)
					, parameters);
		}

		public List<Tuple<int, int>> GetReproductionCapacity(List<int> ids) {
			var intermediate = _ticketRepo.Data()
				.GroupBy(t => t.ReproductionId)
				.Select(g => new {Key = g.Key, Count = g.Count()});


			var query = _repository.Data()
				.Where(r => ids.Contains(r.Id))
				.Include(r => r.Theater)
				.Join(intermediate, 
					reproduction => reproduction.Id, 
					arg => arg.Key, 
					(rep, arg) => new Tuple<Reproduction, int>(rep, arg.Count));

			return query
				.ToList()
				.Select(t => new Tuple<int, int>(t.Item1.Id, t.Item1.Theater.Capacity - t.Item2))
				.ToList();
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