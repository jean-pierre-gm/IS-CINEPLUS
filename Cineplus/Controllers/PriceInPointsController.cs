using System.Collections.Generic;
using System.Security.Cryptography.Xml;
using Cineplus.Models;
using Cineplus.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cineplus.Controllers {
	[Route("/api/[controller]")]
	public class PriceInPointsController {

		private IPointsService _pointsService;
		public PriceInPointsController(IPointsService pointsService) {
			_pointsService = pointsService;
		}

		[HttpGet]
		public ActionResult<List<int>> Index() {
			return new List<int> {_pointsService.GetPriceInPoints()};
		}

		[HttpPut]
		public ActionResult<List<int>> Put([FromQuery] int newPrice) {
			return new List<int>() {_pointsService.SetPriceInPoints(newPrice)};
		}

	}
}