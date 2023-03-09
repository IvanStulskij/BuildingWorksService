using BuildingWorks.Databasable.Entities.Plans;
using BuildingWorks.Models.Resources.Plans;

namespace BuildingWorks.Services.Interfaces.Plans
{
    public interface IPlanDetailsService : IService<PlanDetailResource, PlanDetailForm>
    {
        float CountDonePercent(int planId);

        IEnumerable<PlanDetailResource> GetByPlan(int planId);

        IEnumerable<PlanDetailResource> GetCompleted(IEnumerable<PlanDetail> planDetails);
    }
}