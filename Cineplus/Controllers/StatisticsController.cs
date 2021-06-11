using System.Collections.Generic;
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
    }
}