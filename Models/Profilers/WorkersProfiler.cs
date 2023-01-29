using AutoMapper;
using BuildingWorks.Models.Databasable.Tables.Workers;
using Models.Resources.Workers;

namespace BuildingWorks.Models.Profilers
{
    public class WorkersProfiler : Profile
    {
        public WorkersProfiler()
        {
            CreateMap<Worker, WorkerResource>().ReverseMap();
        }
    }
}
