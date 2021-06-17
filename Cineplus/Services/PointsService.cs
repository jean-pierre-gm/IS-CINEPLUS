using System;
using System.Linq;
using Cineplus.Models;

namespace Cineplus.Services {
	public class PointsService : IPointsService {

		private IRepository<PriceInPoints> _repository;
		public PointsService(IRepository<PriceInPoints> repository) {
			_repository = repository;
		}

		public int GetPriceInPoints() {
			return _repository.Data().FirstOrDefault()?.Value ?? 20;
		}

		public int SetPriceInPoints(int newPrice) {
			if (newPrice <= 0) throw new ArgumentException("Price most be a positive number");
			
			var priceInPoints = _repository.Data().FirstOrDefault();
			if (priceInPoints == null) {
				return _repository.Add(new PriceInPoints() {Id = 0, Value = newPrice}).Value;
			} else {
				priceInPoints.Value = newPrice;
				return _repository.Update(priceInPoints).Value;
			}
		}
	}
}