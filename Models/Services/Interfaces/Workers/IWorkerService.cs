using BuildingWorks.Models.Databasable.Tables.Workers;
using Models;
using Models.Resources.Workers;

namespace BuildingWorks.Models.Services.Interfaces.Workers
{
    public interface IWorkerService : IService<WorkerResource, WorkerForm>
    {

        IEnumerable<Worker> GetBrigadeWorkers(int brigadeCode);

        IEnumerable<Worker> GetByCondition(Condition condition);
    }
}
