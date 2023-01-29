using AutoMapper;
using BuildingWorks.Models.Databasable.Tables.Plans;
using Models.Resources.Plans;

namespace Models.Profilers
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
