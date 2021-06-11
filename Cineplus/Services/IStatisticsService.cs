using Cineplus.Models;

namespace Cineplus.Services
{
    public interface IStatisticsService
    {
        Pagination<GroupByDate> MovieSeenDays(int id, Pagination<GroupByDate> parameters);

        Pagination<GroupByDate> MovieSeenMonths(int id, Pagination<GroupByDate> parameters);

        Pagination<GroupByDate> MovieSeenYears(int id, Pagination<GroupByDate> parameters);
    }
}