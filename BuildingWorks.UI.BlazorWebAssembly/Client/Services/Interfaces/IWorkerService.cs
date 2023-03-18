using BuildingWorks.Models;
using BuildingWorks.Models.Overview;
using BuildingWorks.Models.Resources.Workers;
using Models;

namespace BuildingWorks.UI.BlazorWebAssembly.Client.Services.Interfaces
{
    public interface IWorkerService : IOverviewService<WorkerForm, WorkerResource, WorkerOverview>
    {
        IEnumerable<WorkerResource> GetByCondition(Condition condition);

        IEnumerable<WorkerResource> GetByBrigade(PaginationParameters pagination, int brigadeCode);
    }
}
