using System;
using System.Collections.Generic;
using System.Drawing.Printing;
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
		public ActionResult<IEnumerable<Reproduction>> Index([FromQuery] int? movieId) {
			if (movieId == null) {
				return new ActionResult<IEnumerable<Reproduction>>(_reproductionService.GetAll());
			}
			return new ActionResult<IEnumerable<Reproduction>>(_reproductionService.GetAllOfMovie(movieId.Value));
		}

		[HttpGet("{id:int}")]
		public ActionResult<Reproduction> GetMovie(int id) {
			return _reproductionService.Get(id);
		}

		[HttpGet("{date:datetime}")]
		public ActionResult<Pagination<Reproduction>> GetReproductionsAtDate(DateTime date)
		{
			return new ActionResult<Pagination<Reproduction>>(_reproductionService.GetAllAtDay(date));
		}

		[HttpPost]
		public ActionResult<Reproduction> PostReproduction([FromBody] Reproduction reproduction)
		{
			_reproductionService.Add(reproduction);
			return reproduction;
		}

		[HttpPost("{id:int}")]
		public ActionResult<Reproduction> RemoveReproduction(int id)
		{
			Reproduction reproduction = _reproductionService.Get(id);
			_reproductionService.Remove(id);
			return reproduction;
		}
	}
}