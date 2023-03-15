using BuildingWorks.Databasable.Entities.Plans;
using BuildingWorks.Models.Overview;
using BuildingWorks.Models.Resources.Plans;

namespace BuildingWorks.Services.Interfaces.Plans
{
    public interface IPlanDetailsService : IOverviewService<PlanDetailResource, PlanDetailForm, PlanDetailOverview>
    {
        float CountDonePercent(int planId);

        IEnumerable<PlanDetail> GetByPlan(int planId);

        IEnumerable<PlanDetail> GetCompleted(IEnumerable<PlanDetail> planDetails);
    }
}