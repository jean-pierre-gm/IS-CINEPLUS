using System;
using System.Collections.Generic;
using System.Linq;
using Cineplus.Models;
using Cineplus.Services;
using IdentityServer4.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cineplus.Controllers
{
    // missing auth atribute decorator for all class
    [Authorize]
    [Route("/api/[controller]")]
    public class TicketController : Controller
    {
        private ITicketService _ticketService;

        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

         
      
        [HttpPost("order/{type}/")]
        public ActionResult MakeOrder([FromBody]Guid order,string type)
        {
           return _ticketService.MakeOrder(order,type);
        }
        
        
        [HttpGet("order")]
        public ActionResult<Pagination<IGrouping<Guid, Ticket>>> GetOrders(
            [FromQuery] Pagination<IGrouping<Guid, Ticket>> parameters)
        {
            return new ActionResult<Pagination<IGrouping<Guid, Ticket>>>(
                _ticketService.PaginatedOrders(parameters));
        }
        

        [HttpDelete("order/{order:guid}")]
        public ActionResult CancelOrder(Guid order)
        {
            return _ticketService.CancelOrder(order);
        }


        [HttpPost]
        public ActionResult MakeReserve([FromBody] List<Ticket> partialTickets)
        {
            return _ticketService.MakeReserveForUser(partialTickets);
        }


        [HttpGet("reserved/{reprodId:int}")]
        public ActionResult<IEnumerable<Ticket>> GetUserReservedTicketsForReproduction(int reprodId)
        {
            return new ActionResult<IEnumerable<Ticket>>(
                _ticketService.GetAllTicketsForUserAtReproduction(reprodId));
        }


        [HttpDelete("{ticketId:int}")]
        public ActionResult CancelReserve(int ticketId)
        {
            return _ticketService.CancelReserve(ticketId);
        }
    }
}