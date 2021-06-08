using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Cineplus.Models {
	public class Seat: DbEntity {

		[Required]
		public int Column { get; set; }
		[Required]
		public int Row { get; set; }

		public int TheaterId { get; set; }
		[JsonIgnore]
		public virtual Theater Theater { get; set; }
	}
}