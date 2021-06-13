using Cineplus.Models;
using Cineplus.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cineplus.Controllers
{
    [Route("/api/[controller]")]
    public class StatisticsController : Controller
    {
        private IStatisticsService _statisticsService;
        
        public StatisticsController(IStatisticsService statisticsService)
        {
            _statisticsService = statisticsService;
        }
        
        [HttpGet]
        [Route("day/{movie:int}")]
        public ActionResult<Pagination<GroupByDate>> MovieSeenPerDay(int movie, [FromQuery]Pagination<GroupByDate> parameters)
        {
            return new ActionResult<Pagination<GroupByDate>>(_statisticsService.MovieSeenDays(movie, parameters));
        }
        
        [HttpGet]
        [Route("month/{movie:int}")]
        public ActionResult<Pagination<GroupByDate>> MovieSeenPerMonth(int movie, [FromQuery]Pagination<GroupByDate> parameters)
        {
            return new ActionResult<Pagination<GroupByDate>>(_statisticsService.MovieSeenMonths(movie, parameters));
        }
        
        [HttpGet]
        [Route("year/{movie:int}")]
        public ActionResult<Pagination<GroupByDate>> MovieSeenPerYear(int movie, [FromQuery]Pagination<GroupByDate> parameters)
        {
            return new ActionResult<Pagination<GroupByDate>>(_statisticsService.MovieSeenYears(movie, parameters));
        }

        [HttpGet]
        [Route("directors")]
        public ActionResult<Pagination<string>> Directors([FromQuery] Pagination<string> parameters)
        {
            return new ActionResult<Pagination<string>>(_statisticsService.GetDirectors(parameters));
        }
        
        [HttpGet]
        [Route("directors/day/{name}")]
        public ActionResult<Pagination<GroupByDate>> DirectorSeenDays(string name, [FromQuery] Pagination<GroupByDate> parameters)
        {
            return new ActionResult<Pagination<GroupByDate>>(_statisticsService.DirectorSeenDays(name, parameters));
        }
        
        [HttpGet]
        [Route("directors/month/{name}")]
        public ActionResult<Pagination<GroupByDate>> DirectorSeenMonths(string name, [FromQuery] Pagination<GroupByDate> parameters)
        {
            return new ActionResult<Pagination<GroupByDate>>(_statisticsService.DirectorSeenMonths(name, parameters));
        }
        
        [HttpGet]
        [Route("directors/year/{name}")]
        public ActionResult<Pagination<GroupByDate>> DirectorSeenYears(string name, [FromQuery] Pagination<GroupByDate> parameters)
        {
            return new ActionResult<Pagination<GroupByDate>>(_statisticsService.DirectorSeenYears(name, parameters));
        }

        [HttpGet]
        [Route("genres/day/{id:int}")]
        public ActionResult<Pagination<GroupByDate>> GenreSeenDays(int id, Pagination<GroupByDate> parameters)
        {
            return new ActionResult<Pagination<GroupByDate>>(_statisticsService.GenreSeenDays(id, parameters));
        }

        [HttpGet]
        [Route("genres/month/{id:int}")]
        public ActionResult<Pagination<GroupByDate>> GenreSeenMonths(int id, Pagination<GroupByDate> parameters)
        {
            return new ActionResult<Pagination<GroupByDate>>(_statisticsService.GenreSeenMonths(id, parameters));
        }

        [HttpGet]
        [Route("genres/year/{id:int}")]
        public ActionResult<Pagination<GroupByDate>> GenreSeenYears(int id, Pagination<GroupByDate> parameters)
        {
            return new ActionResult<Pagination<GroupByDate>>(_statisticsService.GenreSeenYears(id, parameters));
        }
        
        [HttpGet]
        [Route("actors/day/{id:int}")]
        public ActionResult<Pagination<GroupByDate>> ActorsSeenDays(int id, Pagination<GroupByDate> parameters)
        {
            return new ActionResult<Pagination<GroupByDate>>(_statisticsService.ActorsSeenDays(id, parameters));
        }

        [HttpGet]
        [Route("actors/month/{id:int}")]
        public ActionResult<Pagination<GroupByDate>> ActorsSeenMonths(int id, Pagination<GroupByDate> parameters)
        {
            return new ActionResult<Pagination<GroupByDate>>(_statisticsService.ActorsSeenMonths(id, parameters));
        }

        [HttpGet]
        [Route("actors/year/{id:int}")]
        public ActionResult<Pagination<GroupByDate>> ActorsSeenYears(int id, Pagination<GroupByDate> parameters)
        {
            return new ActionResult<Pagination<GroupByDate>>(_statisticsService.ActorsSeenYears(id, parameters));
        }
    }
}