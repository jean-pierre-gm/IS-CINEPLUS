using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Cineplus.Services;

namespace Cineplus.Models {
	
	public class ApplicationUser : IdentityUser {
		
		[Filter(FilterBy = "username")]
		[Sortable(OrderBy = "username")]
		public override string UserName { get; set; }

		[NotMapped]
		public IList<string> Roles { get; set; }

		public ApplicationUser() {
			this.Roles = new List<string>();
		}
	}
}