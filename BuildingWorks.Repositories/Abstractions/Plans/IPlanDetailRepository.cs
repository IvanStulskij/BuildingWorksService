using BuildingWorks.Databasable.Entities.Plans;

namespace BuildingWorks.Repositories.Abstractions.Plans
{
    public interface IPlanDetailRepository : IRepository<PlanDetail, int>
    {
        Task<float> CountDonePercent(int planId);

        Task<IEnumerable<PlanDetail>> GetCompleted(IEnumerable<PlanDetail> planDetails);

        Task<IEnumerable<PlanDetail>> GetByPlan(int planId);

    }
}