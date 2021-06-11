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
    }
}