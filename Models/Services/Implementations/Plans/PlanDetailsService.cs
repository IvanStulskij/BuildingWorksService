using AutoMapper;
using BuildingWorks.Models.Databasable.Tables.Plans;
using BuildingWorks.Models.Services.Interfaces.Plans;
using Models;
using Models.Repositories.Abstractions.Plans;
using Models.Resources.Plans;

namespace BuildingWorks.Models.Services.Implementations.Plans
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
