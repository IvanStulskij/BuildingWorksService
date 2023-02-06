using AutoMapper;
using BuildingWorks.Databasable.Entities.Workers;
using BuildingWorks.Models.Resources.Workers;

namespace BuildingWorks.Profilers.Profilers.Workers
{
    public class WorkerSalaryProfiler : Profile
    {
        public WorkerSalaryProfiler()
        {
            CreateMap<WorkerSalary, WorkerSalaryResource>().ReverseMap();
            CreateMap<WorkerSalary, WorkerSalaryForm>().ReverseMap();
        }
    }
}