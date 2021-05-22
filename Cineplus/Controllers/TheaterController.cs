using System.Collections.Generic;
using Cineplus.Models;
using Cineplus.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cineplus.Controllers
{
    [Route("/api/[controller]")]
    public class TheaterController
    {
        private ITheaterService _theaterService;

        public TheaterController(ITheaterService theaterService)
        {
            _theaterService = theaterService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Theater>> Index()
        {
            return new ActionResult<IEnumerable<Theater>>(_theaterService.GetAll());
        }

        [HttpPost]
        public ActionResult<Theater> PostTheater([FromBody] Theater theater)
        {
            _theaterService.Add(theater);
            return new ActionResult<Theater>(theater);
        }
    }
}