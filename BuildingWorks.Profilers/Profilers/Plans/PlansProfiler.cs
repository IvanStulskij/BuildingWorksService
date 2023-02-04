using AutoMapper;
using BuildingWorks.Models.Databasable.Tables.Plans;
using Models.Resources.Plans;

namespace BuildingWorks.Models.Profilers.Plans
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
