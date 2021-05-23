using System;
using Cineplus.Models;
using Cineplus.Services;
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
			return new ActionResult<Pagination<Reproduction>>(_reproductionService.GetAllOfMovie(movieId.Value, parameters));
		}

		[HttpGet("{id:int}")]
		public ActionResult<Reproduction> GetMovie(int id) {
			return _reproductionService.Get(id);
		}

		[HttpGet("{date:datetime}")]
		public ActionResult<Pagination<Reproduction>> GetReproductionsAtDate(DateTime date, [FromQuery] Pagination<Reproduction> parameters)
		{
			return new ActionResult<Pagination<Reproduction>>(_reproductionService.GetAllAtDay(date, parameters));
		}

		[HttpPost]
		public ActionResult<Reproduction> PostReproduction([FromBody] Reproduction reproduction)
		{
			_reproductionService.Add(reproduction);
			return reproduction;
		}

		[HttpPost("{id:int}")]
		[Route("api/[controller]/delete")]
		public ActionResult<Reproduction> RemoveReproduction(int id)
		{
			Reproduction reproduction = _reproductionService.Get(id);
			_reproductionService.Remove(id);
			return reproduction;
		}
	}
}