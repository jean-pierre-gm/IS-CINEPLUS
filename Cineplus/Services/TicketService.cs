using System.Collections.Generic;
using System.Linq;
using Cineplus.Models;

namespace Cineplus.Services {
	public class TicketService: ITicketService {
		private IRepository<Ticket> _repository;
		public TicketService(IRepository<Ticket> repository) {
			_repository = repository;
		}

		public Ticket Get(int id) {
			return _repository.Data().FirstOrDefault(ticket => ticket.Id == id);
		}

		public IEnumerable<Ticket> GetAllFromReproduction(int reproductionId) {
			return _repository.Data().Where(ticket => ticket.ReproductionId == reproductionId).AsEnumerable();
		}

		public IEnumerable<Ticket> GetAllTicketsForUserAtReproduction(string userId, int reproductionId) {
			return _repository.Data()
				.Where(ticket => ticket.ReproductionId == reproductionId && ticket.UserId == userId).AsEnumerable();
		}

		public Ticket Add(Ticket entity) {
			return _repository.Add(entity);
		}

		public Ticket Update(Ticket entity) {
			return _repository.Update(entity);
		}

		public Ticket Remove(int id) {
			return _repository.Remove(id);
		}
	}
}