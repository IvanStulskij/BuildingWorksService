using BuildingWorks.Databasable.Entities.Plans;

namespace BuildingWorks.Repositories.Repositories.Abstractions.Plans
{
    public interface IPlanDetailRepository : IRepository<PlanDetail, int>
    {
        float CountDonePercent(int planId);

        IEnumerable<PlanDetail> FindCompleted(IEnumerable<PlanDetail> planDetails);

        IEnumerable<PlanDetail> FindByPlan(int planId);

    }
}