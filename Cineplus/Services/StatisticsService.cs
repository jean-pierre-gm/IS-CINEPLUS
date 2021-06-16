using System;
using System.Linq;
using Cineplus.Models;
using Microsoft.EntityFrameworkCore;

namespace Cineplus.Services
{
    public class StatisticsService: IStatisticsService
    {
        private IRepository<Ticket> _ticketRepository;
        private IRepository<Movie> _movieRepository;
        

        public StatisticsService(IRepository<Ticket> ticketRepository, IRepository<Movie> movieRepository)
        {
            _ticketRepository = ticketRepository;
            _movieRepository = movieRepository;
        }
        
        public Pagination<GroupByDate> MovieSeenDays(int id, Pagination<GroupByDate> parameters)
        {
            var data = _ticketRepository.Data()
                .Include(ticket => ticket.Reproduction)
                .Where(ticket => ticket.Reproduction.MovieId == id)
                .GroupBy(t => t.Reproduction.StartTime.Date)
                .Select(g => new GroupByDate(){
                    Key = g.Key,
                    Count = g.Count()
                });
            return PaginationService.GetPagination(data, parameters);
        }

        public Pagination<GroupByDate> MovieSeenMonths(int id, Pagination<GroupByDate> parameters)
        {
            var data = _ticketRepository.Data()
                .Include(ticket => ticket.Reproduction)
                .Where(ticket => ticket.Reproduction.MovieId == id)
                .GroupBy(t => new {t.Reproduction.StartTime.Date.Month, t.Reproduction.StartTime.Year})
                .Select(g => new GroupByDate(){
                    Key = new DateTime(g.Key.Year, g.Key.Month, 1),
                    Count = g.Count()
                });
            return PaginationService.GetPagination(data, parameters);
        }

        public Pagination<GroupByDate> MovieSeenYears(int id, Pagination<GroupByDate> parameters)
        {
            var data = _ticketRepository.Data()
                .Include(ticket => ticket.Reproduction)
                .Where(ticket => ticket.Reproduction.MovieId == id)
                .GroupBy(t => t.Reproduction.StartTime.Year)
                .Select(g => new GroupByDate(){
                    Key = new DateTime(g.Key, 1, 1),
                    Count = g.Count()
                });
            return PaginationService.GetPagination(data, parameters);
        }

        public Pagination<GroupByDate> DirectorSeenDays(string name, Pagination<GroupByDate> parameters)
        {
            var data = _ticketRepository.Data()
                .Include(ticket => ticket.Reproduction).ThenInclude(reproduction =>  reproduction.Movie)
                .Where(ticket => ticket.Reproduction.Movie.Director == name)
                .GroupBy(t => t.Reproduction.StartTime.Date)
                .Select(g => new GroupByDate(){
                    Key = g.Key,
                    Count = g.Count()
                });
            return PaginationService.GetPagination(data, parameters);
        }

        public Pagination<GroupByDate> DirectorSeenMonths(string name, Pagination<GroupByDate> parameters)
        {
            var data = _ticketRepository.Data()
                .Include(ticket => ticket.Reproduction).ThenInclude(reproduction =>  reproduction.Movie)
                .Where(ticket => ticket.Reproduction.Movie.Director == name)
                .GroupBy(t => new {t.Reproduction.StartTime.Date.Month, t.Reproduction.StartTime.Year})
                .Select(g => new GroupByDate(){
                    Key = new DateTime(g.Key.Year, g.Key.Month, 1),
                    Count = g.Count()
                });
            return PaginationService.GetPagination(data, parameters);
        }

        public Pagination<GroupByDate> DirectorSeenYears(string name, Pagination<GroupByDate> parameters)
        {
            var data = _ticketRepository.Data()
                .Include(ticket => ticket.Reproduction).ThenInclude(reproduction =>  reproduction.Movie)
                .Where(ticket => ticket.Reproduction.Movie.Director == name)
                .GroupBy(t => t.Reproduction.StartTime.Year)
                .Select(g => new GroupByDate(){
                    Key = new DateTime(g.Key, 1, 1),
                    Count = g.Count()
                });
            return PaginationService.GetPagination(data, parameters);
        }

        public Pagination<string> GetDirectors(Pagination<string> parameters)
        {
            var data = _movieRepository.Data().Select(g => g.Director).Distinct();
            return PaginationService.GetPagination(data, parameters);
        }

        public Pagination<GroupByDate> GenreSeenDays(int id, Pagination<GroupByDate> parameters)
        {
            var data = _ticketRepository.Data()
                .Include(ticket => ticket.Reproduction).ThenInclude(reproduction =>  reproduction.Movie)
                .Where(ticket => ticket.Reproduction.Movie.GenreId == id)
                .GroupBy(t => t.Reproduction.StartTime.Date)
                .Select(g => new GroupByDate(){
                    Key = g.Key,
                    Count = g.Count()
                });
            return PaginationService.GetPagination(data, parameters);
        }

        public Pagination<GroupByDate> GenreSeenMonths(int id, Pagination<GroupByDate> parameters)
        {
            var data = _ticketRepository.Data()
                .Include(ticket => ticket.Reproduction).ThenInclude(reproduction =>  reproduction.Movie)
                .Where(ticket => ticket.Reproduction.Movie.GenreId == id)
                .GroupBy(t => new {t.Reproduction.StartTime.Date.Month, t.Reproduction.StartTime.Year})
                .Select(g => new GroupByDate(){
                    Key = new DateTime(g.Key.Year, g.Key.Month, 1),
                    Count = g.Count()
                });
            return PaginationService.GetPagination(data, parameters);
        }

        public Pagination<GroupByDate> GenreSeenYears(int id, Pagination<GroupByDate> parameters)
        {
            var data = _ticketRepository.Data()
                .Include(ticket => ticket.Reproduction).ThenInclude(reproduction =>  reproduction.Movie)
                .Where(ticket => ticket.Reproduction.Movie.GenreId == id)
                .GroupBy(t => t.Reproduction.StartTime.Year)
                .Select(g => new GroupByDate(){
                    Key = new DateTime(g.Key, 1, 1),
                    Count = g.Count()
                });
            return PaginationService.GetPagination(data, parameters);
        }

        public Pagination<GroupByDate> ActorsSeenDays(int id, Pagination<GroupByDate> parameters)
        {
            var data = _ticketRepository.Data()
                .Include(ticket => ticket.Reproduction)
                .ThenInclude(reproduction =>  reproduction.Movie)
                .ThenInclude(movie => movie.Actors)
                .Where(ticket => ticket.Reproduction.Movie.Actors.Any(actorMovie =>  actorMovie.ActorId == id))
                .GroupBy(t => t.Reproduction.StartTime.Date)
                .Select(g => new GroupByDate(){
                    Key = g.Key,
                    Count = g.Count()
                });
            return PaginationService.GetPagination(data, parameters);
        }

        public Pagination<GroupByDate> ActorsSeenMonths(int id, Pagination<GroupByDate> parameters)
        {
            var data = _ticketRepository.Data()
                .Include(ticket => ticket.Reproduction)
                .ThenInclude(reproduction =>  reproduction.Movie)
                .ThenInclude(movie => movie.Actors)
                .Where(ticket => ticket.Reproduction.Movie.Actors.Any(actorMovie =>  actorMovie.ActorId == id))
                .GroupBy(t => new {t.Reproduction.StartTime.Date.Month, t.Reproduction.StartTime.Year})
                .Select(g => new GroupByDate(){
                    Key = new DateTime(g.Key.Year, g.Key.Month, 1),
                    Count = g.Count()
                });
            return PaginationService.GetPagination(data, parameters);
        }

        public Pagination<GroupByDate> ActorsSeenYears(int id, Pagination<GroupByDate> parameters)
        {
            var data = _ticketRepository.Data()
                .Include(ticket => ticket.Reproduction)
                .ThenInclude(reproduction =>  reproduction.Movie)
                .ThenInclude(movie => movie.Actors)
                .Where(ticket => ticket.Reproduction.Movie.Actors.Any(actorMovie =>  actorMovie.ActorId == id))
                .GroupBy(t => t.Reproduction.StartTime.Year)
                .Select(g => new GroupByDate(){
                    Key = new DateTime(g.Key, 1, 1),
                    Count = g.Count()
                });
            return PaginationService.GetPagination(data, parameters);
        }

        public Pagination<GroupByDate> CountrySeenDays(string country, bool exclude, Pagination<GroupByDate> parameters)
        {
            var data = _ticketRepository.Data()
                .Include(ticket => ticket.Reproduction)
                .ThenInclude(reproduction => reproduction.Movie);
            IQueryable<Ticket> conditionData;
            if (!exclude)
                conditionData = data.Where(ticket => ticket.Reproduction.Movie.Country == country);
            else 
                conditionData = data.Where(ticket => ticket.Reproduction.Movie.Country != country);
            var finalData = conditionData
                .GroupBy(t => t.Reproduction.StartTime.Date)
                .Select(g => new GroupByDate(){
                    Key = g.Key,
                    Count = g.Count()
                });
            return PaginationService.GetPagination(finalData, parameters);
        }

        public Pagination<GroupByDate> CountrySeenMonths(string country, bool exclude, Pagination<GroupByDate> parameters)
        {
            var data = _ticketRepository.Data()
                .Include(ticket => ticket.Reproduction)
                .ThenInclude(reproduction => reproduction.Movie);
            IQueryable<Ticket> conditionData;
            if (!exclude)
                conditionData = data.Where(ticket => ticket.Reproduction.Movie.Country == country);
            else 
                conditionData = data.Where(ticket => ticket.Reproduction.Movie.Country != country);
            var finalData = conditionData
                .GroupBy(t => new {t.Reproduction.StartTime.Date.Month, t.Reproduction.StartTime.Year})
                .Select(g => new GroupByDate(){
                    Key = new DateTime(g.Key.Year, g.Key.Month, 1),
                    Count = g.Count()
                });
            return PaginationService.GetPagination(finalData, parameters);
        }

        public Pagination<GroupByDate> CountrySeenYears(string country, bool exclude,Pagination<GroupByDate> parameters)
        {
            var data = _ticketRepository.Data()
                .Include(ticket => ticket.Reproduction)
                .ThenInclude(reproduction => reproduction.Movie);
            IQueryable<Ticket> conditionData;
            if (!exclude)
                conditionData = data.Where(ticket => ticket.Reproduction.Movie.Country == country);
            else 
                conditionData = data.Where(ticket => ticket.Reproduction.Movie.Country != country);
            var finalData = conditionData.GroupBy(t => t.Reproduction.StartTime.Year)
                .Select(g => new GroupByDate(){
                    Key = new DateTime(g.Key, 1, 1),
                    Count = g.Count()
                });
            return PaginationService.GetPagination(finalData, parameters);
        }

        public Pagination<GroupByName> TopSeenMovies(DateTime start, DateTime end, Pagination<GroupByName> parameters)
        {
            var data = _ticketRepository.Data()
                .Include(ticket => ticket.Reproduction)
                .ThenInclude(reproduction => reproduction.Movie)
                .Where(ticket => ticket.Reproduction.StartTime >= start && ticket.Reproduction.StartTime <= end)
                .GroupBy(t => t.Reproduction.Movie.MovieName)
                .Select(arg => new GroupByName() {Key = arg.Key, Count = arg.Count()})
                .OrderByDescending(arg => arg.Count);
            
            return PaginationService.GetPagination(data, parameters);
        }

        public Pagination<GroupByDate> ScoreSeenDays(float scoreMin, float scoreMax, Pagination<GroupByDate> parameters)
        {
            var data = _ticketRepository.Data()
                .Include(ticket => ticket.Reproduction)
                .ThenInclude(reproduction =>  reproduction.Movie)
                .Where(ticket => ticket.Reproduction.Movie.Score >= scoreMin && ticket.Reproduction.Movie.Score <= scoreMax)
                .GroupBy(t => t.Reproduction.StartTime.Date)
                .Select(g => new GroupByDate(){
                    Key = g.Key,
                    Count = g.Count()
                });
            return PaginationService.GetPagination(data, parameters);
        }

        public Pagination<GroupByDate> ScoreSeenMonths(float scoreMin, float scoreMax, Pagination<GroupByDate> parameters)
        {
            var data = _ticketRepository.Data()
                .Include(ticket => ticket.Reproduction)
                .ThenInclude(reproduction =>  reproduction.Movie)
                .Where(ticket => ticket.Reproduction.Movie.Score >= scoreMin && ticket.Reproduction.Movie.Score <= scoreMax)
                .GroupBy(t => new {t.Reproduction.StartTime.Date.Month, t.Reproduction.StartTime.Year})
                .Select(g => new GroupByDate(){
                    Key = new DateTime(g.Key.Year, g.Key.Month, 1),
                    Count = g.Count()
                });
            return PaginationService.GetPagination(data, parameters);
        }

        public Pagination<GroupByDate> ScoreSeenYears(float scoreMin, float scoreMax, Pagination<GroupByDate> parameters)
        {
            var data = _ticketRepository.Data()
                .Include(ticket => ticket.Reproduction)
                .ThenInclude(reproduction =>  reproduction.Movie)
                .Where(ticket => ticket.Reproduction.Movie.Score >= scoreMin && ticket.Reproduction.Movie.Score <= scoreMax)
                .GroupBy(t => t.Reproduction.StartTime.Year)
                .Select(g => new GroupByDate(){
                    Key = new DateTime(g.Key, 1, 1),
                    Count = g.Count()
                });
            return PaginationService.GetPagination(data, parameters);
        }
    }
}