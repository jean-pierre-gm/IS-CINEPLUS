using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cineplus.Models {
	public class ApplicationUser : IdentityUser {
		[NotMapped]
		public IList<string> Roles { get; set; }

		public ApplicationUser() {
			this.Roles = new List<string>();
		}
	}
}