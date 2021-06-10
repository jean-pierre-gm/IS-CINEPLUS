using Cineplus.Data;
using Cineplus.Models;
using Cineplus.Services;
using IdentityServer4.EntityFramework.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Moq;
using Xunit;

namespace CineplusTest {
	public class MovieTest {
		private readonly Genre _exampleGenre1 = new Genre() {Id = 1, Description = "Description", GenreName = "Azul"};

		private readonly Movie _exampleMovieWithGenre1 = new Movie() {
			Id = 1,
			MovieName = "TestMovie1",
			Director = "TestDirector1",
			Duration = 123,
			GenreId = 1
		};
		
		private readonly Movie _exampleMovieWithGenre2 = new Movie() {
			Id = 2,
			MovieName = "TestMovie2",
			Director = "TestDirector2",
			Duration = 123,
			GenreId = 1
		};
		
		private readonly Movie _exampleMovieNoGenre1 = new Movie() {
			Id = 3,
			MovieName = "TestMovie3",
			Director = "TestDirector3",
			Duration = 123
		};

		[Fact]
		public void TestGetMoviesWithGenres() {
			
			var options = new DbContextOptionsBuilder<ApplicationDbContext>()
				.UseInMemoryDatabase(databaseName: "TestGetMoviesWithGenresDatabase").Options;
			
			using (var context =
				new ApplicationDbContext(options,
					Options.Create(new OperationalStoreOptions()))) {
				context.Set<Genre>().Add(_exampleGenre1);

				context.Set<Movie>().Add(_exampleMovieWithGenre1);
				context.Set<Movie>().Add(_exampleMovieWithGenre2);
				context.Set<Movie>().Add(_exampleMovieNoGenre1);
				context.SaveChanges();
			}
			
			using (var context =
				new ApplicationDbContext(options,
					Options.Create(new OperationalStoreOptions()))) {
				var movieRepo = new SqlRepository<Movie>(context);
				var displayRepo = new SqlRepository<Settings>(context);
				var displayService = new SettingsService(displayRepo);
				var movieService = new MovieService(movieRepo, displayService, null);
				Pagination<Movie> moviePagination = movieService.GetAllWithGenre(new Pagination<Movie>());
				
				Assert.Equal(2, moviePagination.Result.Count);
			}
		}
		
		[Fact]
		public void TestGetMoviesWithGenresHaveGenreNotNull() {
			var options = new DbContextOptionsBuilder<ApplicationDbContext>()
				.UseInMemoryDatabase(databaseName: "TestGetMoviesWithGenresHaveGenreNotNullDatabase").Options;
			
			using (var context =
				new ApplicationDbContext(options,
					Options.Create(new OperationalStoreOptions()))) {
				context.Set<Genre>().Add(_exampleGenre1);

				context.Set<Movie>().Add(_exampleMovieWithGenre1);
				context.Set<Movie>().Add(_exampleMovieWithGenre2);
				context.Set<Movie>().Add(_exampleMovieNoGenre1);
				context.SaveChanges();
			}
			
			using (var context =
				new ApplicationDbContext(options,
					Options.Create(new OperationalStoreOptions()))) {
				var movieRepo = new SqlRepository<Movie>(context);
				var displayRepo = new SqlRepository<Settings>(context);
				var displayService = new SettingsService(displayRepo);
				var movieService = new MovieService(movieRepo, displayService, null);
				Pagination<Movie> moviePagination = movieService.GetAllWithGenre(new Pagination<Movie>());
				
				Assert.All(moviePagination.Result, movie => Assert.NotNull(movie.Genre));
			}
		}
		
		[Fact]
		public void TestInsertMovieWithGenreNotNull() {
			var options = new DbContextOptionsBuilder<ApplicationDbContext>()
				.UseInMemoryDatabase(databaseName: "TestPostMovieWithGenreNotNullDatabase").Options;
			
			using (var context =
				new ApplicationDbContext(options,
					Options.Create(new OperationalStoreOptions()))) {
				context.Set<Genre>().Add(_exampleGenre1);

				context.Set<Movie>().Add(_exampleMovieWithGenre1);
				context.Set<Movie>().Add(_exampleMovieWithGenre2);
				context.Set<Movie>().Add(_exampleMovieNoGenre1);
				context.SaveChanges();
			}
			
			using (var context =
				new ApplicationDbContext(options,
					Options.Create(new OperationalStoreOptions()))) {
				var movieRepo = new SqlRepository<Movie>(context);
				var displayRepo = new SqlRepository<Settings>(context);
				var displayService = new SettingsService(displayRepo);
				var movieService = new MovieService(movieRepo, displayService, null);

				var movie = new Movie() {
					Id = 0,
					Director = "Director0",
					Duration = 123, Score = 9.8f,
					MovieName = "Movie0",
					Genre = _exampleGenre1
				};

				var resultMovie = movieService.Add(movie);
				
				Assert.Equal(_exampleGenre1.Id, resultMovie.GenreId);
			}
		}
	}
}