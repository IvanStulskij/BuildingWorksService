using BuildingWorks.Databasable.Entities.Workers;
using Models;

namespace BuildingWorks.Repositories.Abstractions.Workers
{
    public interface IWorkerRepository : IRepository<Worker, int>
    {
        IEnumerable<Worker> GetByCondition(Condition conditition);
        IEnumerable<Worker> GetByBrigade(int brigadeCode);
    }
}