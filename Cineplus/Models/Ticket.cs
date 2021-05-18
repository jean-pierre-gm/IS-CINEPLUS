namespace Cineplus.Models {
	public class Ticket: DbEntity {

		public int SeatId { get; set; }
		public virtual Seat Seat { get; set; }

		public string UserId { get; set; }
		public virtual ApplicationUser User { get; set; }

		public int ReproductionId { get; set; }
		public virtual Reproduction Reproduction { get; set; }
	}
}