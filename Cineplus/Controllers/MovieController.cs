using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cineplus.Models;
using Cineplus.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cineplus.Controllers {
	[Route("/api/[controller]")]
	public class MovieController : Controller {

		private IMovieService _movieService;
		
		public MovieController(IMovieService movieService) {
			_movieService = movieService;
		}

		[HttpGet]
		public ActionResult<Pagination<Movie>> Index([FromQuery] Pagination<Movie> parameters) {
			return new ActionResult<Pagination<Movie>>(_movieService.GetAllWithGenre(parameters));
		}

		[HttpGet("{id:int}")]
		public ActionResult<Movie> GetMovie(int id) {
			return _movieService.Get(id);
		}
		
		[Authorize(Roles = "Admin,Manager", AuthenticationSchemes = IdentityExtensions.AuthenticationScheme)]
		[HttpPut("{id:int}")]
		public ActionResult<Movie> PutMovie(int id, [FromBody] Movie movie) {
			if (id != movie.Id) {
				return BadRequest();
			}
			return _movieService.Update(movie);
		}

		[HttpGet]
		[Route("display")]
		public ActionResult<Pagination<Movie>> PaginationDisplayMovies([FromQuery] Pagination<Movie> parameters)
		{
			return new ActionResult<Pagination<Movie>>(_movieService.GetPaginationDisplay("", parameters));
		}
		
		[HttpGet]
        [Route("display/{name}")]
        public ActionResult<Pagination<Movie>> AllDisplayMovies(string name, [FromQuery] Pagination<Movie> parameters)
        {
        	return new ActionResult<Pagination<Movie>>(_movieService.GetPaginationDisplay(name, parameters));
        }

        [HttpPut]
        [Route("display/manual")]
        public ActionResult<IEnumerable<Movie>> UpdateManualDisplay([FromBody]IEnumerable<Movie> movies)
        {
	        return new ActionResult<IEnumerable<Movie>>(_movieService.SetManualDisplay(movies));
        }

		
		[Authorize(Roles = "Admin,Manager", AuthenticationSchemes = IdentityExtensions.AuthenticationScheme)]
		[HttpPost]
		public ActionResult<Movie> PostMovie([FromBody]Movie movie) {
			_movieService.Add(movie);
			return new ActionResult<Movie>(movie);
		}
	}
}