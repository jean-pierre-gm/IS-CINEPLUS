using System.Collections.Generic;
using System.Linq;
using Cineplus.Models;

namespace Cineplus.Services {
	public class TheaterService: ITheaterService {
		private IRepository<Theater> _repository;
		public TheaterService(IRepository<Theater> repository) {
			_repository = repository;
		}

		public Theater Get(int id) {
			return _repository.Data().FirstOrDefault(theater => theater.Id == id);
		}

		public IEnumerable<Theater> GetAll() {
			return _repository.Data().AsEnumerable();
		}

		public Theater Add(Theater entity) {
			return _repository.Add(entity);
		}

		public Theater Update(Theater entity) {
			return _repository.Update(entity);
		}

		public Theater Remove(int id) {
			return _repository.Remove(id);
		}
	}
}