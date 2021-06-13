using Cineplus.Models;

namespace Cineplus.Services
{
    public interface IStatisticsService
    {
        Pagination<GroupByDate> MovieSeenDays(int id, Pagination<GroupByDate> parameters);
        Pagination<GroupByDate> MovieSeenMonths(int id, Pagination<GroupByDate> parameters);
        Pagination<GroupByDate> MovieSeenYears(int id, Pagination<GroupByDate> parameters);
        Pagination<GroupByDate> DirectorSeenDays(string name, Pagination<GroupByDate> parameters);
        Pagination<GroupByDate> DirectorSeenMonths(string name, Pagination<GroupByDate> parameters);
        Pagination<GroupByDate> DirectorSeenYears(string name, Pagination<GroupByDate> parameters);
        Pagination<string> GetDirectors(Pagination<string> parameters);
        Pagination<GroupByDate> GenreSeenDays(int id, Pagination<GroupByDate> parameters);
        Pagination<GroupByDate> GenreSeenMonths(int id, Pagination<GroupByDate> parameters);
        Pagination<GroupByDate> GenreSeenYears(int id, Pagination<GroupByDate> parameters);
        Pagination<GroupByDate> ActorsSeenDays(int id, Pagination<GroupByDate> parameters);
        Pagination<GroupByDate> ActorsSeenMonths(int id, Pagination<GroupByDate> parameters);
        Pagination<GroupByDate> ActorsSeenYears(int id, Pagination<GroupByDate> parameters);
    }
}