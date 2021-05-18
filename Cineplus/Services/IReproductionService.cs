using System;
using System.Collections.Generic;
using Cineplus.Models;

namespace Cineplus.Services {
	public interface IReproductionService {
		Reproduction Get(int id);
		IEnumerable<Reproduction> GetAllAtDay(DateTime dateTime);
		IEnumerable<Reproduction> GetAllOfMovie(int movieId);
		Reproduction Add(Reproduction entity);
		Reproduction Update(Reproduction entity);
		Reproduction Remove(int id);
		IEnumerable<Reproduction> GetAll();
	}
}