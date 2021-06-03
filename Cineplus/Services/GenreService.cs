using System.Collections.Generic;
using System.Linq;
using Cineplus.Models;

namespace Cineplus.Services {
	public class GenreService: IGenreService {
		private IRepository<Genre> _repository;
		public GenreService(IRepository<Genre> repository) {
			_repository = repository;
		}

		public Genre Get(int id) {
			return _repository.Data().FirstOrDefault(genre => genre.Id == id);
		}

		public Pagination<Genre> GetAll(Pagination<Genre> pagination) {
			return PaginationService.GetPagination(_repository.Data(), pagination);
		}

		public Genre Add(Genre entity) {
			return _repository.Add(entity);
		}

		public Genre Update(Genre entity) {
			return _repository.Update(entity);
		}

		public Genre Remove(int id) {
			return _repository.Remove(id);
		}
	}
}