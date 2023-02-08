using AutoMapper;
using BuildingWorks.Databasable.Entities.Plans;
using BuildingWorks.Models.Overview;
using BuildingWorks.Models.Resources.Plans;

namespace BuildingWorks.Profilers.Profilers.Plans
{
    public class PlanDetailsProfiler : Profile
    {
        public PlanDetailsProfiler()
        {
            CreateMap<PlanDetail, PlanDetailResource>().ReverseMap();
            CreateMap<PlanDetail, PlanDetailForm>().ReverseMap();
            CreateMap<PlanDetail, PlanDetailOverview>()
                .ForMember(x => x.WorkPart, c => c.MapFrom(x => x.WorkPart))
                .ForMember(x => x.IsCompleted, c => c.MapFrom(x => x.IsCompleted))
                .ForMember(x => x.Price, c => c.MapFrom(x => x.Price))
                .ForMember(x => x.PlanId, c => c.MapFrom(x => x.PlanId));
        }
    }
}
