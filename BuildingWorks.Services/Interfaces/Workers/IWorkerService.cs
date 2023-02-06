using BuildingWorks.Models.Resources.Workers;
using Models;

namespace BuildingWorks.Services.Interfaces.Workers
{
    public interface IWorkerService : IService<WorkerResource, WorkerForm>
    {

        IEnumerable<WorkerResource> GetByBrigade(int brigadeCode);

        IEnumerable<WorkerResource> GetByCondition(Condition condition);
    }
}
