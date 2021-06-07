using System.Collections.Generic;
using System.Linq;

namespace Cineplus.Models {
	public interface IRepository<T> where T: DbEntity{
		IQueryable<T> Data(bool tracked = true);
		T Add(T entity);
		T Update(T entity);
		T Remove(int id);
	}
}