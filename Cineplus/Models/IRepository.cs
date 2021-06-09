using System;
using System.Collections.Generic;
using System.Linq;

namespace Cineplus.Models {
	public interface IRepository<T> where T: DbEntity{
		IQueryable<T> Data(bool tracked = true);
		T Add(T entity);
		T Update(T entity);
		IEnumerable<T> UpdateAll(IEnumerable<T> entities);
		T Remove(int id);
		IEnumerable<T> RemoveRange(IQueryable<T> query);
	}
}