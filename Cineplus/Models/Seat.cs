using System.ComponentModel.DataAnnotations;

namespace Cineplus.Models {
	public class Seat: DbEntity {

		[Required]
		public int Column { get; set; }
		[Required]
		public int Row { get; set; }

		public int TheaterId { get; set; }
		public virtual Theater Theater { get; set; }
	}
}