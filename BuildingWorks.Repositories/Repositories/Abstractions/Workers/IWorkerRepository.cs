using BuildingWorks.Models.Databasable.Tables.Workers;

namespace Models.Repositories.Abstractions.Workers
{
    public interface IWorkerRepository : IRepository<Worker, int>
    {
        IEnumerable<Worker> GetByCondition(Condition conditition);
        IEnumerable<Worker> GetBrigadeWorkers(int brigadeCode);
    }
}