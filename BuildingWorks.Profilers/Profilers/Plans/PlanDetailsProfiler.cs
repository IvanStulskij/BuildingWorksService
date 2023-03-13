using BuildingWorks.Databasable.Entities.Plans;
using BuildingWorks.Models.Overview;
using BuildingWorks.Models.Resources.Plans;

namespace BuildingWorks.Profilers.Profilers.Plans
{
    public class PlanDetailsProfiler : BaseOverviewProfiler<PlanDetail, PlanDetailForm, PlanDetailResource, PlanDetailOverview>
    {
        protected override void ConfigureOverviewProfiling()
        {
            CreateMap<PlanDetail, PlanDetailOverview>()
                .ForMember(x => x.WorkPart, c => c.MapFrom(x => x.WorkPart))
                .ForMember(x => x.IsCompleted, c => c.MapFrom(x => x.IsCompleted))
                .ForMember(x => x.Price, c => c.MapFrom(x => x.Price))
                .ForMember(x => x.PlanId, c => c.MapFrom(x => x.PlanId));
        }
    }
}
