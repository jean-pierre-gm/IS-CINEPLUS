using System;
using System.Collections.Generic;
using System.Linq;
using Cineplus.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Cineplus.Services {
	public class TicketService: ITicketService {
		private IRepository<Ticket> _ticketRepository;
		private IRepository<Seat> _seatRepository;
		private IRepository<Reproduction> _reprodRepository;
		public TicketService(IRepository<Ticket> ticketRepository,IRepository<Seat> seatRepository, IRepository<Reproduction> reprodRepository) {
			_ticketRepository = ticketRepository;
			_seatRepository = seatRepository;
			_reprodRepository = reprodRepository;

		}

		private void _purge()
		{
			var dateTimeout = DateTime.Now.AddMinutes(-1);
			_ticketRepository.RemoveRange(_ticketRepository.Data().Where(ticket => !ticket.Confirmed && ticket.ReserveTime <= dateTimeout));
		}

		public IEnumerable<Ticket> MakeReserveForUser(List<Ticket> toReserve,ApplicationUser user)
		{
			_purge();
			List<Ticket> reserved = new List<Ticket>();
			
			//chekcuser
			
			if (user== null || !toReserve.Any()) return reserved;
			
			foreach (var ticket in toReserve)
			{
				var ticketSeat = ticket.Seat;
				var existentSeat = _seatRepository.Data().FirstOrDefault(s =>
					s.TheaterId == ticketSeat.TheaterId && s.Row == ticketSeat.Row &&
					s.Column == ticketSeat.Column);
				if (existentSeat == null) continue;
				var sameReserve = _ticketRepository.Data()
						.FirstOrDefault(t => t.ReproductionId == ticket.ReproductionId && t.Seat == existentSeat);
				if (sameReserve != null) continue;

				var reproduction = _reprodRepository.Data()
					.FirstOrDefault(r => r.Id == ticket.ReproductionId && r.TheaterId == existentSeat.TheaterId);

				if (reproduction==null)continue;
				
				//Verificar los descuentos
				
				ticket.Id = 0;
				ticket.Price = reproduction.Price;
				ticket.ReserveTime = DateTime.Now;
				ticket.User = user;
				reserved.Add(ticket);
				_ticketRepository.Add(ticket);
			}

			return reserved;
		}
		
		public IEnumerable<Ticket> GetAllFromReproduction(int reproductionId) {
			_purge();
			return _ticketRepository.Data().Include(ticket => ticket.Seat).Where(ticket => ticket.ReproductionId == reproductionId).AsEnumerable();
		}

		public IEnumerable<Ticket> GetAllTicketsForUserAtReproduction(ApplicationUser user, int reproductionId) {
			_purge();
			if (user == null)
			{
				return new Ticket[0];
			}
			return _ticketRepository.Data().Include(ticket => ticket.Seat)
				.Where(ticket => ticket.ReproductionId == reproductionId && ticket.UserId == user.Id).AsEnumerable();
		}

		public IQueryable<GroupByCount> GetMovieIdWithTicketsCount() {
			_purge();
			return _ticketRepository.Data()
				.Include(t => t.Reproduction)
				.GroupBy(t => t.Reproduction.MovieId)
				.Select(g => new GroupByCount() {Key = g.Key, Count = g.Count()});
		}
	}
}