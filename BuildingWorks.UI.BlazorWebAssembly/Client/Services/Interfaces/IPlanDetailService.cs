using BuildingWorks.Databasable.Entities.Plans;
using BuildingWorks.Models.Overview;
using BuildingWorks.Models.Resources.Plans;

namespace BuildingWorks.UI.BlazorWebAssembly.Client.Services.Interfaces
{
    public interface IPlanDetailService : IOverviewService<PlanDetailForm, PlanDetailResource, PlanDetailOverview>
    {
        Task<float> CountDonePercent(int planId);

        Task<IEnumerable<PlanDetail>> GetByPlan(int planId);

        Task<IEnumerable<PlanDetail>> GetCompleted(IEnumerable<PlanDetail> planDetails);
    }
}
