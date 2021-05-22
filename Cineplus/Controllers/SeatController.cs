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
        private ISeatService _seatService;

        public SeatController(ISeatService seatService)
        {
            _seatService = seatService;
        }

        [HttpGet("{id:int}")]
        public ActionResult<IEnumerable<Seat>> GetTheaterSeats(int id)
        {
            return new ActionResult<IEnumerable<Seat>>(_seatService.GetAllFromTheater(id));
        }
    }
}