using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Cineplus.Models {
	public static class ModelBuilderExtensions
	{
		public static void Seed(this ModelBuilder modelBuilder)
		{
			
			var settings = new List<Settings>()
			{
				new Settings()
				{
					Id = -1,
					Name = "Best Reviews",
					Active = false,
					Type = "Display"
				},
				new Settings()
				{
					Id = -2,
					Name = "Manual",
					Active = true,
					Type = "Display"
				},
				new Settings()
				{
					Id = -3,
					Name = "Random",
					Active = false,
					Type = "Display"
				},
				new Settings()
				{
					Id = -4,
					Name = "Most seen",
					Active = false,
					Type = "Display"
				}
			};
			
			modelBuilder.Entity<Settings>().HasData(settings);

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
				},
				new Genre()
				{
					Id = -4,
					GenreName = "Science Fiction",
					Description = "All made up"
				},
				new Genre()
				{
					Id = -5,
					GenreName = "Crime",
					Description = "Doing ilegal stuff"
				}
			};

			modelBuilder.Entity<Genre>().HasData(genres);

			var movies = new List<Movie>()
			{
				new Movie() {
					Id = -1,
					MovieName = "Forrest Gump",
					Director = "Robert Zemeckis",
					Description = "A man with a low IQ has accomplished great things in his life and been present during " +
					              "significant historic events—in each case, far exceeding what anyone imagined he could" +
					              " do. But despite all he has achieved, his one true love eludes him.",
					Duration = 142,
					Score = 8.8f,
					GenreId = genres[2].Id,
					ImageUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/h5J4W4veyxMXDMjeNxZI46TsHOb.jpg",
					Display = new DateTime(2021, 6, 6, 15, 0, 0),
					Country = "US"
				},
				new Movie() {
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
					ImageUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/osKZUgKRUK1jwYMdsmlevK7zZIY.jpg",
					Display = new DateTime(2021, 6, 6, 15, 0, 0),
					Country = "US"
				},
				new Movie() {
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
					ImageUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/RYMX2wcKCBAr24UyPD7xwmjaTn.jpg",
					Display = new DateTime(2021, 6, 6, 15, 0, 0),
					Country = "US"
				},
				new Movie() {
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
					ImageUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/kWWAt2FMRbqLFFy8o5R4Zr8cMAb.jpg",
					Display = new DateTime(2021, 6, 6, 15, 0, 0),
					Country = "US"
				},
				new Movie() {
					Id = -5,
					MovieName = "The Hunger Games: Mockingjay - Part 1",
					Director = "Francis Lawrence",
					Duration = 123,
					Score = 6.8f,
					Description = "Katniss Everdeen reluctantly becomes the symbol of a mass rebellion " +
					              "against the autocratic Capitol.",
					GenreId = genres[3].Id,
					ImageUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/4FAA18ZIja70d1Tu5hr5cj2q1sB.jpg",
					Display = new DateTime(2021, 6, 6, 15, 0, 0),
					Country = "US"
				},
				new Movie() {
					Id = -6,
					MovieName = "La La Land",
					Director = "Damien Chazelle",
					Duration = 129,
					Score = 7.9f,
					Description = "Mia, an aspiring actress, serves lattes to movie stars in between auditions and Sebastian," +
					              " a jazz musician, scrapes by playing cocktail party gigs in dingy bars, but as success " +
					              "mounts they are faced with decisions that begin to fray the fragile fabric of their love " +
					              "affair, and the dreams they worked so hard to maintain in each other threaten to rip them apart.",
					GenreId = genres[2].Id,
					ImageUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/uDO8zWDhfWwoFdKS4fzkUJt0Rf0.jpg",
					Display = new DateTime(2021, 6, 6, 15, 0, 0),
					Country = "US"
				},
				new Movie() {
					Id = -7,
					MovieName = "Cruella",
					Director = "Craig Gillespie",
					Duration = 134,
					Score = 8.7f,
					Description = "In 1970s London amidst the punk rock revolution, a young grifter named Estella is " +
					              "determined to make a name for herself with her designs. She befriends a pair of young " +
					              "thieves who appreciate her appetite for mischief, and together they are able to build a " +
					              "life for themselves on the London streets. One day, Estella’s flair for fashion catches " +
					              "the eye of the Baroness von Hellman, a fashion legend who is devastatingly chic and " +
					              "terrifyingly haute. But their relationship sets in motion a course of events and " +
					              "revelations that will cause Estella to embrace her wicked side and become the raucous," +
					              " fashionable and revenge-bent Cruella.",
					GenreId = genres[0].Id,
					ImageUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/A0knvX7rlwTyZSKj8H5NiARb45.jpg",
					Display = new DateTime(2021, 6, 6, 15, 0, 0),
					Country = "US"
				},
				new Movie() {
					Id = -8,
					MovieName = "The Shawshank Redemption",
					Director = "Frank Darabont",
					Duration = 144,
					Score = 8.7f,
					Description = "Framed in the 1940s for the double murder of his wife and her lover, upstanding banker " +
					              "Andy Dufresne begins a new life at the Shawshank prison, where he puts his accounting " +
					              "skills to work for an amoral warden. During his long stretch in prison, Dufresne comes " +
					              "to be admired by the other inmates -- including an older prisoner named Red -- for his " +
					              "integrity and unquenchable sense of hope.",
					GenreId = genres[2].Id,
					ImageUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/q6y0Go1tsGEsmtFryDOJo3dEmqu.jpg",
					Display = new DateTime(2021, 6, 6, 15, 0, 0),
					Country = "US"
				},
				new Movie() {
					Id = -9,
					MovieName = "The Godfather",
					Director = "Francis Ford Coppola",
					Duration = 175,
					Score = 8.7f,
					Description = "Spanning the years 1945 to 1955, a chronicle of the fictional Italian-American Corleone crime family. " +
					              "When organized crime family patriarch, Vito Corleone barely survives an attempt on his life, " +
					              "his youngest son, Michael steps in to take care of the would-be killers, launching a campaign " +
					              "of bloody revenge.",
					GenreId = genres[2].Id,
					ImageUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/3bhkrj58Vtu7enYsRolD1fZdja1.jpg",
					Display = new DateTime(2021, 6, 6, 15, 0, 0),
					Country = "US"
				},
				new Movie() {
					Id = -10,
					MovieName = "Your Name.",
					Director = "Makoto Shinkai",
					Duration = 104,
					Score = 8.6f,
					Description = "High schoolers Mitsuha and Taki are complete strangers living separate lives. But one night, " +
					              "they suddenly switch places. Mitsuha wakes up in Taki’s body, and he in hers. This bizarre " +
					              "occurrence continues to happen randomly, and the two must adjust their lives around each other.",
					GenreId = genres[2].Id,
					ImageUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/q719jXXEzOoYaps6babgKnONONX.jpg",
					Display = new DateTime(2021, 6, 6, 15, 0, 0),
					Country = "JP"
				},
				new Movie() {
					Id = -11,
					MovieName = "Pulp Fiction",
					Director = "Makoto Shinkai",
					Duration = 154,
					Score = 8.6f,
					Description = "A burger-loving hit man, his philosophical partner, a drug-addled gangster's moll and a" +
					              " washed-up boxer converge in this sprawling, comedic crime caper. Their adventures " +
					              "unfurl in three stories that ingeniously trip back and forth in time.",
					GenreId = genres[4].Id,
					ImageUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/d5iIlFn5s0ImszYzBPb8JPIfbXD.jpg",
					Display = new DateTime(2021, 6, 4, 15, 0, 0),
					Country = "US"
				},
				new Movie() {
					Id = -12,
					MovieName = "John Wick",
					Director = "Chad Stahelski",
					Duration = 101,
					Score = 7.3f,
					Description = "Ex-hitman John Wick comes out of retirement to track down the gangsters that " +
					              "took everything from him.",
					GenreId = genres[1].Id,
					ImageUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/fZPSd91yGE9fCcCe6OoQr6E3Bev.jpg",
					Display = new DateTime(2021, 6, 4, 15, 0, 0),
					Country = "US"
				},
				new Movie()
				{
					Id = -13,
					MovieName = "Strawberry and Chocolate",
					Director = "Tomás Gutiérrez Alea",
					Duration = 108,
					Score = 7.3f,
					Description = "Havana, Cuba, 1979. Flamboyantly gay artist Diego (Jorge Perugorría) attempts to seduce the " +
					              "straight and strait-laced David, an idealistic young communist, and fails dismally. But " +
					              "David conspires to become friends with Diego so he can monitor the artist's subversive " +
					              "life for the state. As Diego and David discuss politics, individuality and personal " +
					              "expression in Castro's Cuba, a genuine friendship develops between the two. But can " +
					              "it last? Strawberry and Chocolate became an instant hit when it was released, and has " +
					              "become a classic of Cuban cinema due to its charming and authentic exploration of a " +
					              "connection between two people under historical circumstances that seem levelled against them.",
					GenreId = genres[0].Id,
					ImageUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/tMwUsu080E4kS4rkHPffy1ugvaJ.jpg",
					Display = new DateTime(2021, 5, 4, 15, 0, 0),
					Country = "CU"
				}
			};
			
			var actors = new List<Actor>()
			{
				new Actor() { Id = -1, ActorName = "Tom Hanks"},
				new Actor() { Id = -2, ActorName = "Robin Wright"},
				new Actor() { Id = -3, ActorName = "Harrison Ford"},
				new Actor(){ Id = -4, ActorName = "Sean Connery"},
				new Actor() { Id = -5, ActorName = "Robert Downey Jr."},
				new Actor() { Id = -6, ActorName = "Chris Evans"},
				new Actor() { Id = -7, ActorName = "Jack Nicholson"},
				new Actor() { Id = -8, ActorName = "Leonardo DiCaprio"},
				new Actor() { Id = -9, ActorName = "Jennifer Lawrence"},
				new Actor() { Id = -10, ActorName = "Josh Hutcherson"},
				new Actor() { Id = -11, ActorName = "Ryan Gosling"},
				new Actor() { Id = -12, ActorName = "Emma Stone"},
				new Actor() { Id = -13, ActorName = "Emma Thompson"},
				new Actor() { Id = -14, ActorName = "Tim Robbins"},
				new Actor() { Id = -15, ActorName = "Morgan Freeman"},
				new Actor() { Id = -16, ActorName = "Al Pacino"},
				new Actor() { Id = -17, ActorName = "Marlon Brando"},
				new Actor() { Id = -18, ActorName = "Ryunosuke Kamiki"},
				new Actor() { Id = -19, ActorName = "Mone Kamishiraishi"},
				new Actor() { Id = -20, ActorName = "John Travolta"},
				new Actor() { Id = -21, ActorName = "Samuel L. Jackson"},
				new Actor() { Id = -22, ActorName = "Keanu Reeves"},
				new Actor() { Id = -23, ActorName = "Michael Nyqvist"},
				new Actor() { Id = -24, ActorName = "Jorge Perugorría"},
				new Actor() { Id = -25, ActorName = "Vladimir Cruz"}
			};

			modelBuilder.Entity<Actor>().HasData(actors);

			var actorMovies = new List<ActorMovie>()
			{
				new ActorMovie() {Id = -1, ActorId = actors[0].Id, MovieId = movies[0].Id},
				new ActorMovie() {Id = -2, ActorId = actors[1].Id, MovieId = movies[0].Id},
				new ActorMovie() {Id = -3, ActorId = actors[2].Id, MovieId = movies[1].Id},
				new ActorMovie() {Id = -4, ActorId = actors[3].Id, MovieId = movies[1].Id},
				new ActorMovie() {Id = -5, ActorId = actors[4].Id, MovieId = movies[2].Id},
				new ActorMovie() {Id = -6, ActorId = actors[5].Id, MovieId = movies[2].Id},
				new ActorMovie() {Id = -7, ActorId = actors[6].Id, MovieId = movies[3].Id},
				new ActorMovie() {Id = -8, ActorId = actors[7].Id, MovieId = movies[3].Id},
				new ActorMovie() {Id = -9, ActorId = actors[8].Id, MovieId = movies[4].Id},
				new ActorMovie() {Id = -10, ActorId = actors[9].Id, MovieId = movies[4].Id},
				new ActorMovie() {Id = -11, ActorId = actors[10].Id, MovieId = movies[5].Id},
				new ActorMovie() {Id = -12, ActorId = actors[11].Id, MovieId = movies[5].Id},
				new ActorMovie() {Id = -13, ActorId = actors[11].Id, MovieId = movies[6].Id},
				new ActorMovie() {Id = -14, ActorId = actors[12].Id, MovieId = movies[6].Id},
				new ActorMovie() {Id = -15, ActorId = actors[13].Id, MovieId = movies[7].Id},
				new ActorMovie() {Id = -16, ActorId = actors[14].Id, MovieId = movies[7].Id},
				new ActorMovie() {Id = -17, ActorId = actors[15].Id, MovieId = movies[8].Id},
				new ActorMovie() {Id = -18, ActorId = actors[16].Id, MovieId = movies[8].Id},
				new ActorMovie() {Id = -19, ActorId = actors[17].Id, MovieId = movies[9].Id},
				new ActorMovie() {Id = -20, ActorId = actors[18].Id, MovieId = movies[9].Id},
				new ActorMovie() {Id = -21, ActorId = actors[19].Id, MovieId = movies[10].Id},
				new ActorMovie() {Id = -22, ActorId = actors[20].Id, MovieId = movies[10].Id},
				new ActorMovie() {Id = -23, ActorId = actors[21].Id, MovieId = movies[11].Id},
				new ActorMovie() {Id = -24, ActorId = actors[22].Id, MovieId = movies[11].Id},
				new ActorMovie() {Id = -25, ActorId = actors[23].Id, MovieId = movies[12].Id},
				new ActorMovie() {Id = -26, ActorId = actors[24].Id, MovieId = movies[12].Id}
			};

			modelBuilder.Entity<ActorMovie>().HasData(actorMovies);
			
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
					PersonalName = "FEU",
					Description = "Descuento para los integrantes de la FEU",
					Discount = 10,
				},
				new PersonalDiscount() {
					Id = -2,
					PersonalName = "Discapacitados",
					Description = "Descuento para los discapacitados",
					Discount = 10,
				},
				new PersonalDiscount() {
					Id = -3,
					PersonalName = "Personal",
					Description = "Descuento para los trabajadores del centro",
					Discount = 50,
				},
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
							OrderId = new Guid(),
							Confirmation = new Guid()
						});
					}
				}
			}
			modelBuilder.Entity<Ticket>().HasData(tickets);
			modelBuilder.Entity<DateDiscount>().HasData(dateDiscounts);
			modelBuilder.Entity<PersonalDiscount>().HasData(personalDiscounts);
		}
	}
}