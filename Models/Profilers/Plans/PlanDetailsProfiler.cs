using AutoMapper;
using BuildingWorks.Models.Databasable.Tables.Plans;
using Models.Resources.Plans;

namespace BuildingWorks.Models.Profilers.Plans
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
