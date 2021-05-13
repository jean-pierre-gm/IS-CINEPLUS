using System;
using System.Collections.Generic;
using System.Linq;
using Cineplus.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cineplus.Controllers {
	[Route("/api/[controller]")]
	public class GenreController: Controller {
		private IRepository<Genre> _repository;
		
		public GenreController(IRepository<Genre> repository) {
			_repository = repository;
		}
		
		[HttpGet]
		public ActionResult<IEnumerable<Genre>> Index() {
			return new ActionResult<IEnumerable<Genre>>(_repository.GetAll());
		}

		[HttpPost]
		public ActionResult<Genre> PostMovie([FromBody]Genre genre) {
			_repository.Add(genre);
			return new ActionResult<Genre>(genre);
		}
	}
}