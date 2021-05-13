using System.Collections.Generic;

namespace Cineplus.Models {
	public interface IRepository<T> {
		T Get(int id);
		ICollection<T> GetAll();
		T Add(T entity);
		T Update(T entity);
		T Remove(int id);
	}
}