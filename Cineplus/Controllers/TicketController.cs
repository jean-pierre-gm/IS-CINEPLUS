using System.Collections.Generic;
using Cineplus.Models;
using Cineplus.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cineplus.Controllers
{
    [Route("/api/[controller]")]
    public class TicketController : Controller
    {
            private ITicketService _ticketService;
		
            public TicketController(ITicketService ticketService) {
                _ticketService = ticketService;
            }


            [HttpGet("{id:int}")]
            public ActionResult<IEnumerable<Ticket>> GetTicketsFromReproduction(int id) {
                return  new  ActionResult<IEnumerable<Ticket>>(_ticketService.GetAllFromReproduction(id));
            }
            [HttpGet("{id:int},{uid}")]
            public ActionResult<IEnumerable<Ticket>> GetTicketsFromReproductionAndUser(int id,string uid) {
                return  new  ActionResult<IEnumerable<Ticket>>(_ticketService.GetAllTicketsForUserAtReproduction(uid,id));
            }
        }
}