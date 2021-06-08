using System.Collections.Generic;
using Cineplus.Models;

namespace Cineplus.Services
{
    public interface ITicketService
    {
        Ticket Get(int id);
        IEnumerable<Ticket> MakeReserveForUser(List<Ticket> toReserve, ApplicationUser user);
        IEnumerable<Ticket> GetAllFromReproduction(int reproductionId);
        IEnumerable<Ticket> GetAllTicketsForUserAtReproduction(string userId, int reproductionId);
    }
}