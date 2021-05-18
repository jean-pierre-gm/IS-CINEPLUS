using System.Collections.Generic;
using System.Linq;

namespace Cineplus.Models {
	public interface IRepository<T> {
		IQueryable<T> Data();
		T Add(T entity);
		T Update(T entity);
		T Remove(int id);
	}
}