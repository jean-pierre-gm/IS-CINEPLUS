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
    }
}