using Cineplus.Models;

namespace Cineplus.Services {
	public interface IPointsService {
		int GetPriceInPoints();

		int SetPriceInPoints(int newPrice);
	}
}