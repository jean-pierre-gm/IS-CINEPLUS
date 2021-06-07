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
				},
				new Genre()
				{
					Id = -3,
					GenreName = "Drama",
					Description = "Making drama"
				}
			};

			modelBuilder.Entity<Genre>().HasData(genres);

			var movies = new List<Movie>()
			{
				new Movie()
				{
					Id = -1,
					MovieName = "Forrest Gump",
					Director = "Robert Zemeckis",
					Description = "A man with a low IQ has accomplished great things in his life and been present during " +
					              "significant historic events—in each case, far exceeding what anyone imagined he could" +
					              " do. But despite all he has achieved, his one true love eludes him.",
					Duration = 142,
					Score = 8.8f,
					GenreId = genres[2].Id,
					ImageUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/h5J4W4veyxMXDMjeNxZI46TsHOb.jpg"
				},
				new Movie()
				{
					Id = -2,
					MovieName = "Indiana Jones and the Last Crusade",
					Director = "Steven Spielberg",
					Description = "When Dr. Henry Jones Sr. suddenly goes missing while pursuing the Holy Grail, " +
					              "eminent archaeologist Indiana must team up with Marcus Brody, Sallah and Elsa Schneider" +
					              " to follow in his father's footsteps and stop the Nazis from recovering the power of " +
					              "eternal life.",
					Duration = 127,
					Score = 7.8f,
					GenreId = genres[1].Id,
					ImageUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/osKZUgKRUK1jwYMdsmlevK7zZIY.jpg"
				},
				new Movie()
				{
					Id = -3,
					MovieName = "The Avengers",
					Director = "Joss Whedon",
					Duration = 143,
					Description = "When an unexpected enemy emerges and threatens global safety and security, Nick Fury, " +
					              "director of the international peacekeeping agency known as S.H.I.E.L.D., finds himself" +
					              " in need of a team to pull the world back from the brink of disaster. Spanning the globe," +
					              " a daring recruitment effort begins!",
					Score = 7.7f,
					GenreId = genres[1].Id,
					ImageUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/RYMX2wcKCBAr24UyPD7xwmjaTn.jpg"
				},
				new Movie()
				{
					Id = -4,
					MovieName = "The Departed",
					Director = "Martin Scorsese",
					Duration = 149,
					Score = 8.2f,
					Description = "To take down South Boston's Irish Mafia, the police send in one of their own to " +
					              "infiltrate the underworld, not realizing the syndicate has done likewise. While an " +
					              "undercover cop curries favor with the mob kingpin, a career criminal rises through the " +
					              "police ranks. But both sides soon discover there's a mole among them.",
					GenreId = genres[2].Id,
					ImageUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/kWWAt2FMRbqLFFy8o5R4Zr8cMAb.jpg"
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
					StartTime = new DateTime(2021, 6, 6, 18, 0, 0),
					TheaterId = -1,
					Price = 10
				},
				new Reproduction()
				{
					Id = -2,
					MovieId = -1,
					StartTime = new DateTime(2021, 6, 6, 22, 0, 0),
					TheaterId = -1,
					Price = 12
				},
				new Reproduction()
				{
					Id = -3,
					MovieId = -1,
					StartTime = new DateTime(2021, 6, 6, 18, 0, 0),
					TheaterId = -2,
					Price = 9
				},
				new Reproduction()
				{
					Id = -4,
					MovieId = -1,
					StartTime = new DateTime(2021, 6, 6, 18, 0, 0),
					TheaterId = -3,
					Price = 8
				},
				new Reproduction()
				{
					Id = -5,
					MovieId = -1,
					StartTime = new DateTime(2021, 6, 6, 22, 0, 0),
					TheaterId = -3,
					Price = 14
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
							SeatId = theaterSeat.Id,
							Price = reproduction.Price,
							Confirmed = true
						});
					}
				}
			}
			modelBuilder.Entity<Ticket>().HasData(tickets);
		}
	}
}