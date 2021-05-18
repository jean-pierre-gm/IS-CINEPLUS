using System;
using System.Collections.Generic;
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
		public ActionResult<IEnumerable<Reproduction>> GetReproductionsAtDate(DateTime date) {
			return new ActionResult<IEnumerable<Reproduction>>(_reproductionService.GetAllAtDay(date));
		}
	}
}