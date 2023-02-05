using AutoMapper;
using BuildingWorks.Databasable.Entities.Workers;
using BuildingWorks.Models.Resources.Workers;

namespace BuildingWorks.Profilers.Profilers.Workers
{
    public class WorkersProfiler : Profile
    {
        public WorkersProfiler()
        {
            CreateMap<Worker, WorkerResource>().ReverseMap();
            CreateMap<Worker, WorkerForm>().ReverseMap();
        }
    }
}