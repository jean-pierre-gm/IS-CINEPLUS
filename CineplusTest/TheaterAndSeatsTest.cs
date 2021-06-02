using System.Collections.Generic;
using Cineplus.Data;
using Cineplus.Models;
using Cineplus.Services;
using IdentityServer4.EntityFramework.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Xunit;

namespace CineplusTest
{
    public class TheaterAndSeatsTest
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
            Rows = 3,
            Columns = 7
        };

        [Fact]
        public void TestGetTheaters()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestGetTheaterDatabase").Options;
			
            using (var context =
                new ApplicationDbContext(options,
                    Options.Create(new OperationalStoreOptions()))) {
                context.Set<Theater>().Add(_theater1);
                context.Set<Theater>().Add(_theater2);
                context.SaveChanges();
            }
			
            using (var context =
                new ApplicationDbContext(options,
                    Options.Create(new OperationalStoreOptions()))) {
                var theaterRepo = new SqlRepository<Theater>(context);
                var theaterService = new TheaterService(theaterRepo);
                List<Theater> theaters = new List<Theater>(theaterService.GetAll());
                
                Assert.Equal(2, theaters.Count);
            }
        }

        [Fact]
        public void TestInsertSeatsWithTheater()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestInsertTheater").Options;

            using (var context =
                new ApplicationDbContext(options,
                    Options.Create(new OperationalStoreOptions())))
            {
                var theaterRepo = new SqlRepository<Theater>(context);
                var theaterService = new TheaterService(theaterRepo);
                
                var seatsRepo = new SqlRepository<Seat>(context);
                var seatsService = new SeatService(seatsRepo);

                var resultTheater = theaterService.Add(_theater1);
                var seats = new List<Seat>(seatsService.GetAllFromTheater(resultTheater.Id));
                
                Assert.Equal(seats.Count, resultTheater.Rows*resultTheater.Columns);
                Assert.All(seats, seat => Assert.Equal(seat.TheaterId, resultTheater.Id));
            }
        }
    }
}