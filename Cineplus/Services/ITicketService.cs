using System.Collections.Generic;
using Cineplus.Models;

namespace Cineplus.Services
{
    public interface ITicketService
    {
        IEnumerable<Ticket> MakeReserveForUser(List<Ticket> toReserve, ApplicationUser user);
        IEnumerable<Ticket> GetAllFromReproduction(int reproductionId);
        IEnumerable<Ticket> GetAllTicketsForUserAtReproduction(ApplicationUser user, int reproductionId);
    }
}