using BuildingWorks.Databasable.Entities.Workers;

namespace BuildingWorks.Repositories.Abstractions.Workers
{
    public interface IBrigadeRepository : IRepository<Brigade, int>
    {
        IEnumerable<int> GetBrigadesCodes();

        IEnumerable<Brigade> GetObjectBrigades(int objectCode);
    }
}