using BuildingWorks.Models.Databasable.Tables.Workers;

namespace Models.Repositories.Abstractions.Workers
{
    public interface IBrigadeRepository : IRepository<Brigade, int>
    {
        IEnumerable<int> SelectBrigadesCodes();

        IEnumerable<Brigade> GetObjectBrigades(int objectCode);
    }
}