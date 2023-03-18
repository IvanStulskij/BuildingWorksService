using AutoMapper;
using BuildingWorks.Databasable;
using BuildingWorks.Databasable.Entities.Workers;
using BuildingWorks.Models.Resources.Workers;
using BuildingWorks.Repositories.Abstractions.Workers;
using BuildingWorks.Services.Bases;
using BuildingWorks.Services.Interfaces.Workers;

namespace BuildingWorks.Services.Implementations.Workers
{
    public class WorkerSalaryService :
        Service<WorkerSalary, WorkerSalaryResource, WorkerSalaryForm>,
        IWorkerSalaryService
    {
        public WorkerSalaryService(BuildingWorksDbContext context, IMapper mapper, IWorkerSalaryRepository repository) : base(context, mapper)
        {
            Repository = repository;
        }

        public override IWorkerSalaryRepository Repository { get; }

        public float GetTotalBAmountByObject(int objectId)
        {
            return Repository.GetTotalSalaries(objectId);
        }
    }
}
