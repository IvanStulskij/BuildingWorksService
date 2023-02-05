using BuildingWorks.Databasable.Entities.Workers;

namespace BuildingWorks.Repositories.Repositories.Abstractions.Workers
{
    public interface IWorkerSalaryRepository : IRepository<WorkerSalary, int>
    {
        float GetObjectTotalSalaries(int objectCode);
    }
}