using System.Collections.Generic;
using System.Linq;
using Cineplus.Models;
using Microsoft.EntityFrameworkCore;

namespace Cineplus.Services {
	public class SeatService: ISeatService {
		private IRepository<Seat> _repository;
		public SeatService(IRepository<Seat> repository) {
			_repository = repository;
		}

		public Seat Get(int id) {
			return _repository.Data().FirstOrDefault(seat => seat.Id == id);
		}

		public IEnumerable<Seat> GetAllFromTheater(int theaterId) {
			return _repository.Data().Where(seat => seat.TheaterId == theaterId).AsEnumerable();
		}

		public Seat Add(Seat entity) {
			return _repository.Add(entity);
		}

		public Seat Update(Seat entity) {
			return _repository.Update(entity);
		}

		public Seat Remove(int id) {
			return _repository.Remove(id);
		}
	}
}