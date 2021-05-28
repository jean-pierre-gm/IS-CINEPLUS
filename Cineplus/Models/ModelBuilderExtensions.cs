using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Cineplus.Models {
	public static class ModelBuilderExtensions
	{
		public static void Seed(this ModelBuilder modelBuilder)
		{

			var genres = new List<Genre>()
			{
				new Genre()
				{
					Id = -1,
					Description = "This movies try to make people laugh.",
					GenreName = "Comedy"
				},
				new Genre()
				{
					Id = -2,
					GenreName = "Action",
					Description = "Guns and guns"
				}
			};

			modelBuilder.Entity<Genre>().HasData(genres);

			var movies = new List<Movie>()
			{
				new Movie()
				{
					Id = -1,
					MovieName = "Los 3 de la loma",
					Director = "Pedro Pérez",
					Duration = 134,
					Score = 7.8f,
					GenreId = genres[0].Id
				},
				new Movie()
				{
					Id = -2,
					MovieName = "Donde cayó la tiza",
					Director = "Alfredo Jul",
					Duration = 113,
					Score = 9,
					GenreId = genres[0].Id
				},
				new Movie()
				{
					Id = -3,
					MovieName = "Dos es mejor que uno",
					Director = "Alain Serdán",
					Duration = 130,
					GenreId = genres[1].Id
				}
			};

			modelBuilder.Entity<Movie>().HasData(movies);

			var theaters = new List<Theater>()
			{
				new Theater()
				{
					Id = -1,
					Columns = 10,
					Rows = 15
				},
				new Theater()
				{
					Id = -2,
					Columns = 10,
					Rows = 10
				},
				new Theater()
				{
					Id = -3,
					Columns = 5,
					Rows = 5
				}
			};
			modelBuilder.Entity<Theater>().HasData(theaters);

			var seats = new List<Seat>();
			int counter = -1;

			foreach (var t in theaters)
				for (int i = 0; i < t.Rows; i++)
					for (int j = 0; j < t.Columns; j++)
				{
					seats.Add(new Seat()
					{
						Id = counter,
						Column = j,
						Row = i,
						TheaterId = t.Id
					});
					counter--;
				}

			modelBuilder.Entity<Seat>().HasData(seats);

			var reproductions = new List<Reproduction>()
			{
				new Reproduction()
				{
					Id = -1,
					MovieId = -1,
					StartTime = DateTime.Now,
					TheaterId = -1
				},
				new Reproduction()
				{
					Id = -2,
					MovieId = -1,
					StartTime = DateTime.Now,
					TheaterId = -1
				},
				new Reproduction()
				{
					Id = -3,
					MovieId = -1,
					StartTime = DateTime.Now,
					TheaterId = -2
				},
				new Reproduction()
				{
					Id = -4,
					MovieId = -1,
					StartTime = DateTime.Now,
					TheaterId = -3
				},
				new Reproduction()
				{
					Id = -5,
					MovieId = -1,
					StartTime = DateTime.Now,
					TheaterId = -3
				},
			};
			
			modelBuilder.Entity<Reproduction>().HasData(reproductions);
			Random rnd = new Random(2021);
			var tickets = new List<Ticket>();
			int id = -1;
			foreach (var reproduction in reproductions)
			{
				foreach (var theaterSeat in seats.FindAll(s => s.TheaterId == reproduction.TheaterId) )
				{
					if (rnd.Next(0,101)<=60){
					tickets.Add(new Ticket()
					{
						Id=id--,
						ReproductionId = reproduction.Id,
						SeatId = theaterSeat.Id
					});
					}
				}
			}
			modelBuilder.Entity<Ticket>().HasData(tickets);
		}
	}
}