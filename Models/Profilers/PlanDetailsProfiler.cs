using AutoMapper;
using BuildingWorks.Models.Databasable.Tables.Plans;
using Models.Resources.Plans;

namespace BuildingWorks.Models.Profilers
{
    public class PlanDetailsProfiler : Profile
    {
        public PlanDetailsProfiler()
        {
            CreateMap<PlanDetail, PlanDetailResource>().ReverseMap();
            CreateMap<PlanDetail, PlanDetailForm>().ReverseMap();
        }
    }
}
