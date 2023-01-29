using Models.Resources.Workers;

namespace BuildingWorks.Models.Services.Interfaces.Workers
{
    public interface IWorkerSalaryService : IService<WorkerSalaryResource, WorkerSalaryForm>
    {
        float GetObjectTotalSalaries(int objectId);
    }
}
