using System;
using System.Collections.Generic;
using System.Linq;
using Cineplus.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cineplus.Services
{
    public interface ITicketService
    {
        ActionResult MakeOrder(Guid order, string type);
        Pagination<IGrouping<Guid, Ticket>> PaginatedOrders(Pagination<IGrouping<Guid, Ticket>> parameters);
        ActionResult CancelOrder(Guid orderid);
     
        ActionResult MakeReserveForUser(List<Ticket> toReserve);
        ActionResult CancelReserve(int ticketId);
        
        IEnumerable<Seat> GetAllReservedSeatsForReproduction(int reproductionId);

        IEnumerable<Ticket> GetAllTicketsForUserAtReproduction(int reproductionId,
            bool purchased = false);
        IQueryable<GroupByCount> GetMovieIdWithTicketsCount();
    }
}