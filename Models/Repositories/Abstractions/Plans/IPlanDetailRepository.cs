using BuildingWorks.Models.Databasable.Tables.Plans;

namespace Models.Repositories.Abstractions.Plans
{
    public interface IPlanDetailRepository : IRepository<PlanDetail, int>
    {
        float CountDonePercent(int planId);

        IEnumerable<PlanDetail> FindDoneDetailsByPlan(IEnumerable<PlanDetail> planDetails);

        IEnumerable<PlanDetail> FindDetailsByPlan(int planId);

    }
}