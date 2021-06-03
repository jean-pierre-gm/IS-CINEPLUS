using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Cineplus.Services;

namespace Cineplus.Models {
	public class Movie: DbEntity {

		[Required]
		[Sortable(OrderBy = "name")]
		[Filter(FilterBy = "name")]
		[StringLength(50)]
		public string MovieName { get; set; }

		[Sortable(OrderBy = "score")]
		public float Score { get; set; }

		[Sortable(OrderBy = "duration")]
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