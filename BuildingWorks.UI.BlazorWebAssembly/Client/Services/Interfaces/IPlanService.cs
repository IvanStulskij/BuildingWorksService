using BuildingWorks.Databasable.Entities.Plans;
using BuildingWorks.Models.Overview;
using BuildingWorks.Models.Resources.Plans;
using Models;

namespace BuildingWorks.UI.BlazorWebAssembly.Client.Services.Interfaces
{
    public interface IPlanService : IOverviewService<PlanForm, PlanResource, PlanOverview>
    {
        Task<IEnumerable<string>> GetPropertiesNames();

        Task<IEnumerable<Plan>> GetByCondition(Condition condition);
    }
}
