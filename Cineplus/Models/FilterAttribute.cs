using System;

namespace Cineplus.Models {
	public class FilterAttribute: Attribute {
		public string FilterBy { get; set; }
	}
}