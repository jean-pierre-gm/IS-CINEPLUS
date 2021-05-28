using Newtonsoft.Json;

namespace Cineplus.Models {
	public class Ticket: DbEntity {

		public int SeatId { get; set; }
		public virtual Seat Seat { get; set; }

		[JsonIgnore]
		public string UserId { get; set; }
		[JsonIgnore]
		public virtual ApplicationUser User { get; set; }
		
		[JsonIgnore]
		public double Price { get; set; }
		[JsonIgnore]
		public bool Confirmed { get; set; }

		public int ReproductionId { get; set; }
		public virtual Reproduction Reproduction { get; set; }
	}
}