using BuildingWorks.Databasable.Entities.Workers;

namespace BuildingWorks.Repositories.Abstractions.Workers
{
    public interface IWorkerSalaryRepository : IRepository<WorkerSalary, int>
    {
        float GetTotalSalaries(int objectCode);
    }
}