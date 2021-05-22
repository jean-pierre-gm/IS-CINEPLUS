using System;
using System.Collections.Generic;
using System.Linq;
using Cineplus.Models;

namespace Cineplus.Services {
	public class ReproductionService: IReproductionService {
		private IRepository<Reproduction> _repository;
		public ReproductionService(IRepository<Reproduction> repository) {
			_repository = repository;
		}

		public Reproduction Get(int id) {
			return _repository.Data().FirstOrDefault(r => r.Id == id);
		}

		public Pagination<Reproduction> GetAllAtDay(DateTime dateTime) {
			return PaginationService.GetPagination(
				_repository.Data().Where(reproduction => reproduction.StartTime.Date == dateTime.Date));
		}

		public IEnumerable<Reproduction> GetAllOfMovie(int movieId) {
			return _repository.Data().Where(reproduction => reproduction.MovieId == movieId).AsEnumerable();
		}

		public Reproduction Add(Reproduction entity) {
			if (entity.Movie != null) {
				entity.MovieId = entity.Movie.Id;
				entity.Movie = null;
			}

			if (entity.Theater != null) {
				entity.TheaterId = entity.Theater.Id;
				entity.Theater = null;
			}
			
			return _repository.Add(entity);
		}

		public Reproduction Update(Reproduction entity) {
			return _repository.Update(entity);
		}

		public Reproduction Remove(int id) {
			return _repository.Remove(id);
		}

		public IEnumerable<Reproduction> GetAll() {
			return _repository.Data().AsEnumerable();
		}
	}
}