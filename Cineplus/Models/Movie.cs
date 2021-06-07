using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Cineplus.Services;
using System.Text.Json.Serialization;

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
		
		public string Description { get; set; }
		
		public string ImageUrl { get; set; }

		public int GenreId { get; set; }
		public virtual Genre Genre { get; set; }
		
		[JsonIgnore]
		public virtual ICollection<Reproduction> Reproductions { get; set; }

		public Movie() {
			this.Reproductions = new HashSet<Reproduction>();
		}
	}
}