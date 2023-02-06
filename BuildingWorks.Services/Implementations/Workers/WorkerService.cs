using AutoMapper;
using BuildingWorks.Databasable;
using BuildingWorks.Databasable.Entities.Workers;
using BuildingWorks.Models.Resources.Workers;
using BuildingWorks.Repositories.Repositories.Abstractions.Workers;
using BuildingWorks.Services.Interfaces.Workers;
using Models;

namespace BuildingWorks.Services.Implementations.Workers
{
    public class WorkerService :
        Service<Worker, WorkerResource, WorkerForm>,
        IWorkerService
    {
        public WorkerService(BuildingWorksDbContext context, Mapper mapper) : base(context, mapper)
        {
        }

        public override IWorkerRepository Repository { get; }

        public IEnumerable<WorkerResource> GetByBrigade(int brigadeCode)
        {
            return Mapper.Map<IEnumerable<WorkerResource>>(Repository.GetBrigadeWorkers(brigadeCode));
        }

        public IEnumerable<WorkerResource> GetByCondition(Condition condition)
        {
            return Mapper.Map<IEnumerable<WorkerResource>>(Repository.GetByCondition(condition));
        }
    }
}
