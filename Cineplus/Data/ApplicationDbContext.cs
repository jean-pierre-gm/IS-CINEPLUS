using Cineplus.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cineplus.Data {
	public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser> {
		public ApplicationDbContext(
			DbContextOptions options,
			IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions) { }

		public DbSet<Genre> Genres;
		public DbSet<Movie> Movies;
		public DbSet<DateDiscount> DateDiscounts;
		public DbSet<PersonalDiscount> PersonalDiscounts;
		
		protected override void OnModelCreating(ModelBuilder modelBuilder) {
			base.OnModelCreating(modelBuilder);
			
			modelBuilder.Entity<Genre>()
				.Property(genre => genre.GenreName)
				.IsRequired()
				.HasMaxLength(15);

			modelBuilder.Entity<Movie>()
				.Property(movie => movie.Score)
				.HasConversion<double>();

			modelBuilder.Entity<Associate>()
				.Property(associate => associate.Points)
				.HasDefaultValue(0);
			
			modelBuilder.Entity<DateDiscount>()
				.Property(datediscount => datediscount.Discount)
				.HasConversion<double>();
			
			modelBuilder.Entity<DateDiscount>()
				.Property(datediscount => datediscount.Enable)
				.HasConversion<bool>();
			
			modelBuilder.Entity<PersonalDiscount>()
				.Property(personaldiscount => personaldiscount.Name)
				.IsRequired()
				.HasMaxLength(15);
			
			modelBuilder.Entity<PersonalDiscount>()
				.Property(personaldiscount => personaldiscount.Discount)
				.HasConversion<double>();
			
			modelBuilder.Entity<PersonalDiscount>()
				.Property(personaldiscount => personaldiscount.Enable)
				.HasConversion<bool>();

			modelBuilder.Seed();
		}
	}
}