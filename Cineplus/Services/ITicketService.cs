using System.Collections.Generic;
using Cineplus.Models;

namespace Cineplus.Services {
	public interface ITicketService {
		Ticket Get(int id);
		IEnumerable<Ticket> GetAllFromReproduction(int reproductionId);
		IEnumerable<Ticket> GetAllTicketsForUserAtReproduction(string userId, int reproductionId);
		Ticket Add(Ticket entity);
		Ticket Update(Ticket entity);
		Ticket Remove(int id);
	}
}