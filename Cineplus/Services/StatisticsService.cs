using System;
using System.Linq;
using Cineplus.Models;
using Microsoft.EntityFrameworkCore;

namespace Cineplus.Services
{
    public class StatisticsService: IStatisticsService
    {
        private IRepository<Ticket> _ticketRepository;

        public StatisticsService(IRepository<Ticket> ticketRepository)
        {
            _ticketRepository = ticketRepository;
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
    }
}