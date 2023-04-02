using BuildingWorks.Databasable.Entities.Plans;
using BuildingWorks.Models.Overview;
using BuildingWorks.Models.Resources.Plans;

namespace BuildingWorks.Services.Interfaces.Plans
{
    public interface IPlanDetailsService : IOverviewService<PlanDetailResource, PlanDetailForm, PlanDetailOverview>
    {
        Task<float> CountDonePercent(int planId);

        Task<IEnumerable<PlanDetail>> GetByPlan(int planId);

        Task<IEnumerable<PlanDetail>> GetCompleted(IEnumerable<PlanDetail> planDetails);
    }
}