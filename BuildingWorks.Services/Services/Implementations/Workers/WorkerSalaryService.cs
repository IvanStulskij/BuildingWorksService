using AutoMapper;
using BuildingWorks.Databasable;
using BuildingWorks.Databasable.Entities.Workers;
using BuildingWorks.Models.Resources.Workers;
using BuildingWorks.Repositories.Repositories.Abstractions.Workers;
using BuildingWorks.Services.Interfaces.Workers;

namespace BuildingWorks.Services.Implementations.Workers
{
    public class WorkerSalaryService :
        Service<WorkerSalary, WorkerSalaryResource, WorkerSalaryForm>,
        IWorkerSalaryService
    {
        public WorkerSalaryService(BuildingWorksDbContext context, Mapper mapper) : base(context, mapper)
        {
        }

        public override IWorkerSalaryRepository Repository { get; }

        public float GetTotalByObject(int objectId)
        {
            return Repository.GetObjectTotalSalaries(objectId);
        }
    }
}
