using System.Collections.Generic;
using Cineplus.Models;

namespace Cineplus.Services {
	public interface ISeatService {
		Seat Get(int id);
		IEnumerable<Seat> GetAllFromTheater(int id);
		Seat Add(Seat entity);
		Seat Update(Seat entity);
		Seat Remove(int id);
	}
}