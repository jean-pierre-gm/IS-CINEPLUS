using System;
using Cineplus.Data;
using Cineplus.Models;
using Cineplus.Services;
using IdentityServer4.EntityFramework.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Xunit;

namespace CineplusTest
{
    public class ReproductionTest
    {
        private readonly Theater _theater1 = new Theater()
        {
            Id = 1,
            Rows = 10,
            Columns = 10
        };
        
        private readonly Theater _theater2 = new Theater()
        {
            Id = 2,
            Rows = 10,
            Columns = 10
        };

        private readonly Genre _genre1 = new Genre()
        {
            Id = 3, 
            Description = "Description", 
            GenreName = "Genre 1"
        };

        private readonly Movie _movie1 = new Movie() {
            Id = 4,
            MovieName = "Movie 1",
            Director = "Director 1",
            Duration = 120,
            GenreId = 3
        };
        
        private readonly Movie _movie2 = new Movie() {
            Id = 5,
            MovieName = "Movie 2",
            Director = "Director 2",
            Duration = 180,
            GenreId = 3
        };

        private readonly Reproduction _reproduction1 = new Reproduction()
        {
            Id = 6,
            MovieId = 4,
            Price = 10,
            StartTime = DateTime.Now,
            TheaterId = 1
        };
        
        private readonly Reproduction _reproduction2 = new Reproduction()
        {
            Id = 7,
            MovieId = 5,
            Price = 15,
            StartTime = DateTime.Now,
            TheaterId = 2
        };

        [Fact]
        public void TestGetReproductions()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "GetAllReproductionsDatabase").Options;
			
            using (var context =
                new ApplicationDbContext(options,
                    Options.Create(new OperationalStoreOptions()))) {
                context.Set<Genre>().Add(_genre1);

                context.Set<Theater>().Add(_theater1);
                context.Set<Theater>().Add(_theater2);
                context.Set<Movie>().Add(_movie1);
                context.Set<Movie>().Add(_movie2);
                context.SaveChanges();
            }
			
            using (var context =
                new ApplicationDbContext(options,
                    Options.Create(new OperationalStoreOptions()))) {
                var reproductionRepo = new SqlRepository<Reproduction>(context);
                var ticketRepo = new SqlRepository<Ticket>(context);
                var reproductionService = new ReproductionService(reproductionRepo, ticketRepo);

                reproductionService.Add(_reproduction1);
                reproductionService.Add(_reproduction2);
                
                Pagination<Reproduction> reproductionPagination = reproductionService.GetAll(new Pagination<Reproduction>());
				
                Assert.Equal(2, reproductionPagination.TotalItems);
            }
        }
        
        [Fact]
        public void TestGetAllAtDay()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "GetAllDayReproductionsDatabase").Options;
            
            using (var context =
                new ApplicationDbContext(options,
                    Options.Create(new OperationalStoreOptions()))) {
                context.Set<Genre>().Add(_genre1);

                context.Set<Theater>().Add(_theater1);
                context.Set<Theater>().Add(_theater2);
                context.Set<Movie>().Add(_movie1);
                context.Set<Movie>().Add(_movie2);
                context.SaveChanges();
            }

            using (var context =
                new ApplicationDbContext(options,
                    Options.Create(new OperationalStoreOptions()))) {
                var reproductionRepo = new SqlRepository<Reproduction>(context);
                var ticketRepo = new SqlRepository<Ticket>(context);
                var reproductionService = new ReproductionService(reproductionRepo, ticketRepo);

                reproductionService.Add(_reproduction1);
                reproductionService.Add(_reproduction2);
                
                Pagination<Reproduction> reproductionPagination = reproductionService.GetAllAtDay(DateTime.Now, new Pagination<Reproduction>());
				
                Assert.Equal(2, reproductionPagination.Result.Count);
            }
        }
        
        [Fact]
        public void TestGetAllOfMovie()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "GetAllMovieReproductionsDatabase").Options;
            
            using (var context =
                new ApplicationDbContext(options,
                    Options.Create(new OperationalStoreOptions()))) {
                context.Set<Genre>().Add(_genre1);

                context.Set<Theater>().Add(_theater1);
                context.Set<Theater>().Add(_theater2);
                context.Set<Movie>().Add(_movie1);
                context.Set<Movie>().Add(_movie2);
                context.SaveChanges();
            }

            using (var context =
                new ApplicationDbContext(options,
                    Options.Create(new OperationalStoreOptions()))) {
                var reproductionRepo = new SqlRepository<Reproduction>(context);
                var ticketRepo = new SqlRepository<Ticket>(context);
                var reproductionService = new ReproductionService(reproductionRepo, ticketRepo);

                reproductionService.Add(_reproduction1);
                reproductionService.Add(_reproduction2);
                
                Pagination<Reproduction> reproductionPagination = reproductionService.GetAllOfMovie(_movie1.Id, new Pagination<Reproduction>());
				
                Assert.Single(reproductionPagination.Result);
                Assert.All(reproductionPagination.Result, reproduction => Assert.Equal(_movie1.Id, reproduction.MovieId));
            }
        }

        [Fact]
        public void TestInsertWithMovieAndTheater()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "InsertReproductionDatabase").Options;
            
            using (var context =
                new ApplicationDbContext(options,
                    Options.Create(new OperationalStoreOptions()))) {
                context.Set<Genre>().Add(_genre1);

                context.Set<Theater>().Add(_theater1);
                context.Set<Theater>().Add(_theater2);
                context.Set<Movie>().Add(_movie1);
                context.Set<Movie>().Add(_movie2);
                context.SaveChanges();
            }

            using (var context =
                new ApplicationDbContext(options,
                    Options.Create(new OperationalStoreOptions()))) {
                var reproductionRepo = new SqlRepository<Reproduction>(context);
                var ticketRepo = new SqlRepository<Ticket>(context);
                var reproductionService = new ReproductionService(reproductionRepo, ticketRepo);

                _reproduction1.Movie = _movie1;
                _reproduction1.Theater = _theater1;

                var reproduction = reproductionService.Add(_reproduction1);
                
                Assert.Null(reproduction.Movie);
                Assert.Null(reproduction.Theater);
                Assert.Equal(reproduction.MovieId, _movie1.Id);
                Assert.Equal(reproduction.TheaterId, _theater1.Id);
            }
        }
    }
}