using System;
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
			
			var dateDiscounts = new List<DateDiscount>() {
				new DateDiscount() {
					Id = -1,
					Description = "Descuento del dia del trabajador",
					Discount = 10,
					Date = new DateTime(2021, 5, 1)
				},
				new DateDiscount() {
					Id = -2,
					Description = "Descuento del dia de la lengua española",
					Discount = 10,
					Date = new DateTime(2021, 2, 10)
				},
				new DateDiscount() {
					Id = -3,
					Description = "Descuento del dia del No",
					Discount = 10,
					Date = new DateTime(2021, 10, 28)
				},
			};
			
			var personalDiscounts = new List<PersonalDiscount>() {
				new PersonalDiscount() {
					Id = -1,
					Name = "FEU",
					Description = "Descuento para los integrantes de la FEU",
					Discount = 10,
				},
				new PersonalDiscount() {
					Id = -2,
					Name = "Discapacitados",
					Description = "Descuento para los discapacitados",
					Discount = 10,
				},
				new PersonalDiscount() {
					Id = -3,
					Name = "Personal",
					Description = "Descuento para los trabajadores del centro",
					Discount = 50,
				},
			};

			modelBuilder.Entity<Movie>().HasData(movies);
			modelBuilder.Entity<DateDiscount>().HasData(dateDiscounts);
			modelBuilder.Entity<PersonalDiscount>().HasData(personalDiscounts);
		}
	}
}