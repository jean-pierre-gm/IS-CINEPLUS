using System.Collections.Generic;
using Cineplus.Models;
using Cineplus.Services;
using IdentityServer4.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cineplus.Controllers
{
    [Route("/api/[controller]")]
    public class TicketController : Controller
    {
            private ITicketService _ticketService;
            private readonly IUserService _userService;

            public TicketController(ITicketService ticketService,IUserService userService)
            {
                _ticketService = ticketService;
                _userService = userService;
            }

            [HttpPost]
            public ActionResult<IEnumerable<Ticket>> MakeReserve([FromBody]List<Ticket> partialTickets)
            {
                var user = _userService.GetCurrentUser();
                user.Wait();
                return  new  ActionResult<IEnumerable<Ticket>>(_ticketService.MakeReserveForUser(partialTickets,user.Result));
            }

            [HttpGet("{id:int}")]
            public ActionResult<IEnumerable<Ticket>> GetSoldTicketsFromReproduction(int id) {
                return  new  ActionResult<IEnumerable<Ticket>>(_ticketService.GetAllFromReproduction(id));
            }

            public ActionResult<IEnumerable<Ticket>> GetTicketsFromReproductionAndUser(int id,string uid) {
                return  new  ActionResult<IEnumerable<Ticket>>(_ticketService.GetAllTicketsForUserAtReproduction(uid,id));
            }
        }
}