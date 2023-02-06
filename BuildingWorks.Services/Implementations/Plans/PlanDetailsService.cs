using AutoMapper;
using BuildingWorks.Databasable;
using BuildingWorks.Databasable.Entities.Plans;
using BuildingWorks.Models.Resources.Plans;
using BuildingWorks.Repositories.Repositories.Abstractions.Plans;
using BuildingWorks.Services.Interfaces.Plans;

namespace BuildingWorks.Services.Implementations.Plans
{
    public class PlanDetailsService :
        Service<PlanDetail, PlanDetailResource, PlanDetailForm>,
        IPlanDetailsService
    {
        public PlanDetailsService(BuildingWorksDbContext context, Mapper mapper) : base(context, mapper)
        {
        }

        public override IPlanDetailRepository Repository { get; }

        public float CountDonePercent(int planId)
        {
            return Repository.CountDonePercent(planId);
        }

        public IEnumerable<PlanDetail> GetByPlan(int planId)
        {
            return Repository.FindByPlan(planId);
        }

        public IEnumerable<PlanDetail> GetCompleted(IEnumerable<PlanDetail> planDetails)
        {
            return Repository.FindCompleted(planDetails);
        }
    }
}
