using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Cineplus.Services;

namespace Cineplus.Models {
	public class Genre: DbEntity {
		
		[Filter(FilterBy = "name")]
		[Sortable(OrderBy = "name")]
		public string GenreName { get; set; }
		
		[Column(TypeName="ntext")] 
		public string Description { get; set; }
		
		[JsonIgnore]
		public virtual ICollection<Movie> Movies { get; set; }

		public Genre() {
			this.Movies = new HashSet<Movie>();
		}
		
	}
}