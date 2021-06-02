using System.Collections.Generic;

namespace Cineplus.Models {
	public class Pagination<T> {
		public int CurrentPage { get; set; }

		public int PageSize { get; set; }

		public int TotalPages { get; set; }

		public int TotalItems { get; set; }

		public string OrderBy { get; set; }

		public bool OrderByDesc { get; set; }
		
		public string FilterBy { get; set; }
		
		public string FilterString { get; set; }

		public List<T> Result { get; set; }
	}
}