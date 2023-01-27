using BuildingWorks.Models.Databasable.Tables.Workers;
using Models.Resources.Workers;

namespace Models.Services.Interfaces
{
    public interface IWorkerService
    {
        Task<List<WorkerResource>> GetAll();

        Task<WorkerResource> GetById(int id);

        Task<WorkerResource> Create(WorkerForm worker);

        Task<WorkerResource> Update(WorkerResource resource);

        Task Delete(int codeToDelete);

        IEnumerable<Worker> GetBrigadeWorkers(int brigadeCode);

        IEnumerable<Worker> GetByCondition(Condition condition);
    }
}
