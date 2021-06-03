using System;
using System.Collections.Generic;
using System.Linq;
using Cineplus.Models;
using Cineplus.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cineplus.Controllers {
	[Route("/api/[controller]")]
	public class GenreController: Controller {
		private IGenreService _genreService;
		
		public GenreController(IGenreService genreService) {
			_genreService = genreService;
		}
		
		[HttpGet]
		public ActionResult<Pagination<Genre>> Index([FromQuery] Pagination<Genre> pagination) {
			return new ActionResult<Pagination<Genre>>(_genreService.GetAll(pagination));
		}

		[HttpPost]
		public ActionResult<Genre> PostMovie([FromBody]Genre genre) {
			_genreService.Add(genre);
			return new ActionResult<Genre>(genre);
		}
	}
}