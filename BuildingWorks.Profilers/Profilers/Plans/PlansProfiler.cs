using AutoMapper;
using BuildingWorks.Databasable.Entities.Plans;
using BuildingWorks.Models.Resources.Plans;

namespace BuildingWorks.Profilers.Profilers.Plans
{
    public class PlansProfiler : Profile
    {
        public PlansProfiler()
        {
            CreateMap<Plan, PlanResource>().ReverseMap();
            CreateMap<Plan, PlanForm>().ReverseMap();
        }
    }
}
