using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Cineplus.Models {
	public class Reproduction: DbEntity {

		public int MovieId { get; set; }
		public virtual Movie Movie { get; set; }
		
		public int TheaterId { get; set; }
		public virtual Theater Theater { get; set; }
		
		public DateTime StartTime { get; set; }

		[JsonIgnore]
		public virtual ICollection<Ticket> Tickets { get; set; }

		public Reproduction() {
			this.Tickets = new HashSet<Ticket>();
		}
	}
}