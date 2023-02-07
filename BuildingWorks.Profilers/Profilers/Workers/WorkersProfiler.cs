using AutoMapper;
using BuildingWorks.Databasable.Entities.Workers;
using BuildingWorks.Models.Overview;
using BuildingWorks.Models.Resources.Workers;

namespace BuildingWorks.Profilers.Profilers.Workers
{
    public class WorkersProfiler : Profile
    {
        public WorkersProfiler()
        {
            CreateMap<Worker, WorkerResource>().ReverseMap();
            CreateMap<Worker, WorkerForm>().ReverseMap();
            CreateMap<Worker, WorkerOverview>()
                .ForMember(x => x.FullName, c => c.MapFrom(x => x.FullName))
                .ForMember(x => x.StartWorkDate, c => c.MapFrom(x => x.StartWorkDate))
                .ForMember(x => x.Post, c => c.MapFrom(x => x.WorkerPost))
                .ForMember(x => x.BrigadeId, c => c.MapFrom(x => x.BrigadeId));
        }
    }
}