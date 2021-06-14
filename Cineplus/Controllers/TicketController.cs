using System;
using System.Collections.Generic;
using System.Linq;
using Cineplus.Models;
using Cineplus.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cineplus.Controllers
{
    // missing auth atribute decorator for all class
    
    [Route("/api/[controller]")]
    public class TicketController : Controller
    {
        private ITicketService _ticketService;
        private readonly IUserService _userService;

        public TicketController(ITicketService ticketService, IUserService userService)
        {
            _ticketService = ticketService;
            _userService = userService;
        }

         
      
        [HttpPost("order")]
        public ActionResult MakeOrder([FromBody] Guid order,[FromBody]bool asoc)
        {
            var user = _userService.GetCurrentUser();
            user.Wait();
            return _ticketService.MakeOrder(order, user.Result,asoc);
        }
        
        
        
        [HttpGet("order")]
        public ActionResult<Pagination<IGrouping<Guid, Ticket>>> GetOrders(
            [FromQuery] Pagination<IGrouping<Guid, Ticket>> parameters)
        {
            var user = _userService.GetCurrentUser();
            user.Wait();
            return new ActionResult<Pagination<IGrouping<Guid, Ticket>>>(
                _ticketService.PaginatedOrders(parameters, user.Result));
        }

        [HttpDelete("order/{order:guid}")]
        public ActionResult CancelOrder(Guid order)
        {
            var user = _userService.GetCurrentUser();
            user.Wait();
            return _ticketService.CancelOrder(order, user.Result);
        }


        [HttpPost]
        public ActionResult MakeReserve([FromBody] List<Ticket> partialTickets)
        {
            var user = _userService.GetCurrentUser();
            user.Wait();
            return _ticketService.MakeReserveForUser(partialTickets, user.Result);
        }


        [HttpGet("reserved/{reprodId:int}")]
        public ActionResult<IEnumerable<Ticket>> GetUserReservedTicketsForReproduction(int reprodId)
        {
            var user = _userService.GetCurrentUser();
            user.Wait();
            return new ActionResult<IEnumerable<Ticket>>(
                _ticketService.GetAllTicketsForUserAtReproduction(user.Result, reprodId));
        }


        [HttpDelete("{ticketId:int}")]
        public ActionResult CancelReserve(int ticketId)
        {
            var user = _userService.GetCurrentUser();
            user.Wait();
            return _ticketService.CancelReserve(ticketId, user.Result);
        }
    }
}