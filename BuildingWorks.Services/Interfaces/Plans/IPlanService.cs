using BuildingWorks.Databasable.Entities.Plans;
using BuildingWorks.Models.Overview;
using BuildingWorks.Models.Resources.Plans;

namespace BuildingWorks.Services.Interfaces.Plans
{
    public interface IPlanService : IOverviewService<PlanResource, PlanForm, PlanOverview>, IConditionalService<Plan, PlanResource, PlanForm>
    {
        Task<IEnumerable<string>> GetPropertiesNames();
    }
}