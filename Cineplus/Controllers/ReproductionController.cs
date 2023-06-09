using System;
using System.Collections.Generic;
using Cineplus.Models;
using Cineplus.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cineplus.Controllers {
	[Route("/api/[controller]")]
	public class ReproductionController: Controller {
		private IReproductionService _reproductionService;
		public ReproductionController(IReproductionService reproductionService) {
			_reproductionService = reproductionService;
		}
		
		[HttpGet]
		public ActionResult<Pagination<Reproduction>> Index([FromQuery] int? movieId, [FromQuery] Pagination<Reproduction> parameters) {
			if (movieId == null) {
				return new ActionResult<Pagination<Reproduction>>(_reproductionService.GetAll(parameters));
			}
			return new ActionResult<Pagination<Reproduction>>(_reproductionService.GetAllOfMovieFromNow(movieId.Value, parameters));
		}

		[HttpGet]
		[Route("capacity")]
		public ActionResult<List<Tuple<int, int>>> GetCapacity([FromQuery] List<int> ids) {
			return _reproductionService.GetReproductionCapacity(ids);
		}

		[HttpGet("{id:int}")]
		public ActionResult<Reproduction> GetMovie(int id) {
			return _reproductionService.Get(id);
		}

		[HttpGet]
		[Route("date")]
		public ActionResult<Pagination<Reproduction>> GetReproductionsAtDate([FromQuery]DateTime date, [FromQuery] Pagination<Reproduction> parameters)
		{
			return new ActionResult<Pagination<Reproduction>>(_reproductionService.GetAllAtDay(date, parameters));
		}

		[HttpPost]
		[Authorize(Roles="Admin,Manager", AuthenticationSchemes = IdentityExtensions.AuthenticationScheme)]
		public ActionResult<Reproduction> PostReproduction([FromBody] Reproduction reproduction)
		{
			reproduction = _reproductionService.Add(reproduction);
			if(reproduction is not null)
				return reproduction;
			return BadRequest("Invalid start time");
		}

		[HttpDelete("{id:int}")]
		public ActionResult<Reproduction> RemoveReproduction(int id)
		{
			Reproduction reproduction = _reproductionService.Get(id);
			_reproductionService.Remove(id);
			return reproduction;
		}

		[HttpPut]
		public ActionResult<Reproduction> UpdateReproduction([FromBody] Reproduction reproduction)
		{
			_reproductionService.Update(reproduction);
			return reproduction;
		}
	}
}