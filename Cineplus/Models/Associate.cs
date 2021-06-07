using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Identity;

namespace Cineplus.Models {
	public class Associate: DbEntity {
		
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid Code { get; set; }
		
		[Required]
		public string UserId { get; set; }
		
		[JsonIgnore]
		public ApplicationUser User { get; set; }
		
		public int Points { get; set; }
		
		[Required]
		[StringLength(50)]
		[PersonalData]
		public string Name { get; set; }
		
		[Required]
		[StringLength(50)]
		[PersonalData]
		public string LastName { get; set; }
		
		[Required]
		[PersonalData]
		public string PhoneNumber { get; set; }
		
		[Required]
		[ProtectedPersonalData]
		public string Address { get; set; }
		
	}
}
