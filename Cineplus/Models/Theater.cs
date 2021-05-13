using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cineplus.Models {
	public class Theater: DbEntity {

		[Required]
		public int Capacity { get; set; }

		public virtual ICollection<Seat> Seats { get; set; }

		public virtual ICollection<Reproduction> Reproductions { get; set; }
		
		public Theater() {
			this.Seats = new HashSet<Seat>();
			this.Reproductions = new HashSet<Reproduction>();
		}
	}
}