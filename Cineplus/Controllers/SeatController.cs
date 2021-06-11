using System.Collections;
using System.Collections.Generic;
using Cineplus.Models;
using Cineplus.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cineplus.Controllers
{
    [Route("/api/[controller]")]
    public class SeatController
    {
        private readonly ISeatService _seatService;
        private readonly ITicketService _ticketService;

        public SeatController(ISeatService seatService, ITicketService ticketService)
        {
            _seatService = seatService;
            _ticketService = ticketService;
        }

        [HttpGet("{id:int}")]
        public ActionResult<IEnumerable<Seat>> GetTheaterSeats(int id)
        {
            return new ActionResult<IEnumerable<Seat>>(_seatService.GetAllFromTheater(id));
        }
        
        [HttpGet("reserved/{rid:int}")]
        public ActionResult<IEnumerable<Seat>> GetSoldSeatsFromReproduction(int rid)
        {
            return new ActionResult<IEnumerable<Seat>>(_ticketService.GetAllReservedSeatsForReproduction(rid));
        }

    }
}