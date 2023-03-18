using BuildingWorks.Databasable.Entities.Plans;
using BuildingWorks.Models.Overview;
using BuildingWorks.Models.Resources.Plans;

namespace BuildingWorks.UI.BlazorWebAssembly.Client.Services.Interfaces
{
    public interface IPlanDetailService : IOverviewService<PlanDetailForm, PlanDetailResource, PlanDetailOverview>
    {
        float CountDonePercent(int planId);

        IEnumerable<PlanDetail> GetByPlan(int planId);

        IEnumerable<PlanDetail> GetCompleted(IEnumerable<PlanDetail> planDetails);
    }
}
