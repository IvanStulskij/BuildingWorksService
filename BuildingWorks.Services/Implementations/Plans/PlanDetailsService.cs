using AutoMapper;
using BuildingWorks.Databasable;
using BuildingWorks.Databasable.Entities.Plans;
using BuildingWorks.Models.Overview;
using BuildingWorks.Models.Resources.Plans;
using BuildingWorks.Repositories.Abstractions.Plans;
using BuildingWorks.Services.Bases;
using BuildingWorks.Services.Interfaces.Plans;

namespace BuildingWorks.Services.Implementations.Plans
{
    public class PlanDetailsService :
        OverviewService<PlanDetail, PlanDetailResource, PlanDetailForm, PlanDetailOverview>,
        IPlanDetailsService
    {
        public PlanDetailsService(BuildingWorksDbContext context, IMapper mapper, IPlanDetailRepository repository) : base(context, mapper)
        {
            Repository = repository;
        }

        public override IPlanDetailRepository Repository { get; }

        public async Task<float> CountDonePercent(int planId)
        {
            return await Repository.CountDonePercent(planId);
        }

        public async Task<IEnumerable<PlanDetail>> GetByPlan(int planId)
        {
            return await Repository.GetByPlan(planId);
        }

        public async Task<IEnumerable<PlanDetail>> GetCompleted(IEnumerable<PlanDetail> planDetails)
        {
            return await Repository.GetCompleted(planDetails);
        }
    }
}
