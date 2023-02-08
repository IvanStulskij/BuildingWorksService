using AutoMapper;
using BuildingWorks.Databasable.Entities.Plans;
using BuildingWorks.Models.Overview;
using BuildingWorks.Models.Resources.Plans;

namespace BuildingWorks.Profilers.Profilers.Plans
{
    public class PlansProfiler : Profile
    {
        public PlansProfiler()
        {
            CreateMap<Plan, PlanResource>().ReverseMap();
            CreateMap<Plan, PlanForm>().ReverseMap();
            CreateMap<Plan, PlanOverview>()
                .ForMember(x => x.CompleteTime, c => c.MapFrom(x => x.CompleteTime))
                .ForMember(x => x.IsCompleted, c => c.MapFrom(x => x.IsCompleted))
                .ForMember(x => x.Cost, c => c.MapFrom(x => x.Cost))
                .ForMember(x => x.PathToImage, x => x.MapFrom(x => x.PathToImage))
                .ForMember(x => x.ObjectName, c => c.MapFrom(x => x.Object.ObjectName));
        }
    }
}
