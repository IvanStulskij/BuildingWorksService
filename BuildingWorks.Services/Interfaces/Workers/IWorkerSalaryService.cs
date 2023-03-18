using BuildingWorks.Models.Resources.Workers;

namespace BuildingWorks.Services.Interfaces.Workers
{
    public interface IWorkerSalaryService : IService<WorkerSalaryResource, WorkerSalaryForm>
    {
        float GetTotalBAmountByObject(int objectId);
    }
}
