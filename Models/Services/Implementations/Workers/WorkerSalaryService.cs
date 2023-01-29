using AutoMapper;
using BuildingWorks.Models.Databasable.Tables.Workers;
using BuildingWorks.Models.Services.Interfaces.Workers;
using Models;
using Models.Repositories.Abstractions.Workers;
using Models.Resources.Workers;

namespace BuildingWorks.Models.Services.Implementations.Workers
{
    public class WorkerSalaryService :
        Service<WorkerSalary, WorkerSalaryResource, WorkerSalaryForm>,
        IWorkerSalaryService
    {
        public WorkerSalaryService(BuildingWorksDbContext context, Mapper mapper) : base(context, mapper)
        {
        }

        public override IWorkerSalaryRepository Repository { get; }

        public float GetObjectTotalSalaries(int objectId)
        {
            return Repository.GetObjectTotalSalaries(objectId);
        }
    }
}
