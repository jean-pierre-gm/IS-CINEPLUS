using System;
using System.Collections.Generic;
using System.Linq;
using Cineplus.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cineplus.Services
{
    public interface ITicketService
    {
        ActionResult MakeOrder(Guid order, ApplicationUser user);
        Pagination<IGrouping<Guid, Ticket>> PaginatedOrders(Pagination<IGrouping<Guid, Ticket>> parameters,
            ApplicationUser user);
        ActionResult CancelOrder(Guid orderid, ApplicationUser user);
     
        IEnumerable<Ticket> MakeReserveForUser(List<Ticket> toReserve, ApplicationUser user);
        ActionResult CancelReserve(int ticketId,ApplicationUser user);
        
        IEnumerable<Seat> GetAllReservedSeatsForReproduction(int reproductionId);

        IEnumerable<Ticket> GetAllTicketsForUserAtReproduction(ApplicationUser user, int reproductionId,
            bool purchased = false);
        IQueryable<GroupByCount> GetMovieIdWithTicketsCount();
    }
}