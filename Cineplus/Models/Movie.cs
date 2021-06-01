using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Cineplus.Services;

namespace Cineplus.Models {
	public class Movie: DbEntity {

		[Required]
		[StringLength(50)]
		[Sortable(OrderBy = "name")]
		[Filter(FilterBy = "name")]
		public string MovieName { get; set; }
		
		public float Score { get; set; }

		public int Duration { get; set; }

		public string Director { get; set; }

		public int GenreId { get; set; }
		public virtual Genre Genre { get; set; }
		
		public virtual ICollection<Reproduction> Reproductions { get; set; }

		public Movie() {
			this.Reproductions = new HashSet<Reproduction>();
		}
	}
}