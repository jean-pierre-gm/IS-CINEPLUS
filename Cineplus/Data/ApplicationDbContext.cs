﻿using Cineplus.Models;
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

		protected override void OnModelCreating(ModelBuilder modelBuilder) {
			base.OnModelCreating(modelBuilder);
			
			modelBuilder.Entity<Genre>()
				.Property(genre => genre.GenreName)
				.IsRequired()
				.HasMaxLength(15);

			modelBuilder.Entity<Movie>()
				.Property(movie => movie.Score)
				.HasConversion<double>();
			
			modelBuilder.Seed();
		}
	}
}