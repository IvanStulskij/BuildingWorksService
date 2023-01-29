using AutoMapper;
using BuildingWorks.Models.Databasable.Tables.Workers;
using Models.Resources.Workers;

namespace BuildingWorks.Models.Profilers.Workers
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
