using BuildingWorks.Models.Databasable.Tables.Plans;
using Models.Resources.Plans;

namespace BuildingWorks.Models.Services.Interfaces.Plans
{
    public interface IPlanDetailsService : IService<PlanDetailResource, PlanDetailForm>
    {
        float CountDonePercent(int planId);

        IEnumerable<PlanDetail> GetByPlan(int planId);

        IEnumerable<PlanDetail> GetCompleted(IEnumerable<PlanDetail> planDetails);
    }
}