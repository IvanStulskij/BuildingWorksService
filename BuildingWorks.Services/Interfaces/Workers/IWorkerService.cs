using BuildingWorks.Databasable.Entities.Workers;
using BuildingWorks.Models;
using BuildingWorks.Models.Overview;
using BuildingWorks.Models.Resources.Workers;

namespace BuildingWorks.Services.Interfaces.Workers
{
    public interface IWorkerService : IOverviewService<WorkerResource, WorkerForm, WorkerOverview>, IConditionalService<Worker, WorkerResource, WorkerForm>
    {

        IEnumerable<WorkerResource> GetByBrigade(PaginationParameters pagination, int brigadeCode);
    }
}
