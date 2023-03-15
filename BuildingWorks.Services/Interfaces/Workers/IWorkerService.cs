using BuildingWorks.Models;
using BuildingWorks.Models.Overview;
using BuildingWorks.Models.Resources.Workers;
using Models;

namespace BuildingWorks.Services.Interfaces.Workers
{
    public interface IWorkerService : IOverviewService<WorkerResource, WorkerForm, WorkerOverview>
    {

        IEnumerable<WorkerResource> GetByBrigade(PaginationParameters pagination, int brigadeCode);

        IEnumerable<WorkerResource> GetByCondition(Condition condition);
    }
}
