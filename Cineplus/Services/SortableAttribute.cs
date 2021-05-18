using System;

namespace Cineplus.Services {
	public class SortableAttribute: Attribute {
		public string OrderBy { get; set; }
	}
}