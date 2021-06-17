using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Cineplus.Models {
	public class Theater: DbEntity {

		[Required]
		public int Rows { get; set; }
		[Required]
		public int Columns { get; set; }

		[JsonIgnore]
		public virtual ICollection<Seat> Seats { get; set; }
		
		[JsonIgnore]
		public virtual ICollection<Reproduction> Reproductions { get; set; }

		[NotMapped] public int Capacity => this.Rows * this.Columns;
		
		public Theater() {
			this.Seats = new HashSet<Seat>();
			this.Reproductions = new HashSet<Reproduction>();
		}
	}
}