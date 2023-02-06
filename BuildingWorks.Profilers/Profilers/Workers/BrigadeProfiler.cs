using AutoMapper;
using BuildingWorks.Databasable.Entities.Workers;
using BuildingWorks.Models.Resources.Workers;

namespace BuildingWorks.Profilers.Profilers.Workers
{
    public class BrigadeProfiler : Profile
    {
        public BrigadeProfiler()
        {
            CreateMap<Brigade, BrigadeForm>().ReverseMap();
            CreateMap<Brigade, BrigadeResource>().ReverseMap();
        }
    }
}
