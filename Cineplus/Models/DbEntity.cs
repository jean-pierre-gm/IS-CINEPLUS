using System.ComponentModel.DataAnnotations;

namespace Cineplus.Models {
	public abstract class DbEntity {
		[Key]
		public int Id { get; set; }
	}
}