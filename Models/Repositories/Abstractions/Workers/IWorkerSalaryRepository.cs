using BuildingWorks.Models.Databasable.Tables.Workers;

namespace Models.Repositories.Abstractions.Workers
{
    public interface IWorkerSalaryRepository : IRepository<WorkerSalary, int>
    {
        float GetObjectTotalSalaries(int objectCode);
    }
}