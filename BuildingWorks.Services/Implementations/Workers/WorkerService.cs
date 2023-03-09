using AutoMapper;
using BuildingWorks.Databasable;
using BuildingWorks.Databasable.Entities.Workers;
using BuildingWorks.Models.Resources.Workers;
using BuildingWorks.Repositories.Abstractions.Workers;
using BuildingWorks.Services.Interfaces.Workers;
using Models;

namespace BuildingWorks.Services.Implementations.Workers
{
    public class WorkerService :
        Service<Worker, WorkerResource, WorkerForm>,
        IWorkerService
    {
        public WorkerService(BuildingWorksDbContext context, IMapper mapper, IWorkerRepository repository) : base(context, mapper)
        {
            Repository = repository;
        }

        public override IWorkerRepository Repository { get; }

        public IEnumerable<WorkerResource> GetByBrigade(int brigadeId)
        {
            return Mapper.Map<IEnumerable<WorkerResource>>(Repository.GetByBrigade(brigadeId));
        }

        public IEnumerable<WorkerResource> GetByCondition(Condition condition)
        {
            return Mapper.Map<IEnumerable<WorkerResource>>(Repository.GetByCondition(condition));
        }
    }
}
