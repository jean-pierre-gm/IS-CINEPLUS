using System;
using System.Collections.Generic;
using System.Linq;
using Cineplus.Models;
using Cineplus.Services;
using Microsoft.AspNetCore.Authorization;
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
			return new ActionResult<Genre>(_genreService.Add(genre));
		}
		
		[Authorize(Roles = "Admin,Manager", AuthenticationSchemes = IdentityExtensions.AuthenticationScheme)]
		[HttpPut("{id:int}")]
		public ActionResult<Genre> PutMovie(int id, [FromBody] Genre genre) {
			if (id != genre.Id) {
				return BadRequest();
			}
			return _genreService.Update(genre);
		}
	}
}