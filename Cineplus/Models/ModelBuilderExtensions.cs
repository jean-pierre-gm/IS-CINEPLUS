using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Cineplus.Models {
	public static class ModelBuilderExtensions {
		public static void Seed(this ModelBuilder modelBuilder) {

			var genres = new List<Genre>() {
				new Genre() {
					Id = -1,
					Description = "This movies try to make people laugh.",
					GenreName = "Comedy"
				},
				new Genre() {
					Id = -2,
					GenreName = "Action",
					Description = "Guns and guns"
				}
			};
			
			modelBuilder.Entity<Genre>().HasData(genres);

			var movies = new List<Movie>() {
				new Movie() {
					Id = -1,
					MovieName = "Los 3 de la loma",
					Director = "Pedro Pérez",
					Duration = 134,
					Score = 7.8f,
					GenreId = genres[0].Id
				},
				new Movie() {
					Id = -2,
					MovieName = "Donde cayó la tiza",
					Director = "Alfredo Jul",
					Duration = 113,
					Score = 9,
					GenreId = genres[0].Id
				},
				new Movie() {
					Id = -3,
					MovieName = "Dos es mejor que uno",
					Director = "Alain Serdán",
					Duration = 130,
					GenreId = genres[1].Id
				}
			};

			modelBuilder.Entity<Movie>().HasData(movies);
		}
	}
}