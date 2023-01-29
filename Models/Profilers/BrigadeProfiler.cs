using AutoMapper;
using BuildingWorks.Models.Databasable.Tables.Workers;
using Models.Resources.Workers;

namespace BuildingWorks.Models.Profilers
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
