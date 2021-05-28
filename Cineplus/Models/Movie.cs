using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Cineplus.Services;
using System.Text.Json.Serialization;

namespace Cineplus.Models {
	public class Movie: DbEntity {

		[Required]
		[StringLength(50)]
		[Sortable(OrderBy = "name")]
		public string MovieName { get; set; }
		
		public float Score { get; set; }

		public int Duration { get; set; }

		public string Director { get; set; }
		
		public string Description { get; set; }

		public int GenreId { get; set; }
		public virtual Genre Genre { get; set; }
		
		[JsonIgnore]
		public virtual ICollection<Reproduction> Reproductions { get; set; }

		public Movie() {
			this.Reproductions = new HashSet<Reproduction>();
		}
	}
}