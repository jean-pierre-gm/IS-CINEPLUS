using System;
using System.Collections.Generic;
using Cineplus.Models;

namespace Cineplus.Services {
	public interface IReproductionService {
		Reproduction Get(int id);
		Pagination<Reproduction> GetAllAtDay(DateTime dateTime, Pagination<Reproduction> parameters);
		Pagination<Reproduction> GetAllOfMovie(int movieId, Pagination<Reproduction> parameters);
		Reproduction Add(Reproduction entity);
		Reproduction Update(Reproduction entity);
		Reproduction Remove(int id);
		Pagination<Reproduction> GetAll(Pagination<Reproduction> parameters);
		List<Tuple<int, int>> GetReproductionCapacity(List<int> ids);
	}
}