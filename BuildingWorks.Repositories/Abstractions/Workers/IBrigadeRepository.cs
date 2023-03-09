using BuildingWorks.Databasable.Entities.Workers;
using BuildingWorks.Models;

namespace BuildingWorks.Repositories.Abstractions.Workers
{
    public interface IBrigadeRepository : IRepository<Brigade, int>
    {
        IEnumerable<int> GetCodes(PaginationParameters pagination);

        IEnumerable<Brigade> GetObjectBrigades(int objectCode);
    }
}