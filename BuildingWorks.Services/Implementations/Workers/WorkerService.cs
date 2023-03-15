using AutoMapper;
using BuildingWorks.Databasable;
using BuildingWorks.Databasable.Entities.Workers;
using BuildingWorks.Models;
using BuildingWorks.Models.Overview;
using BuildingWorks.Models.Resources.Workers;
using BuildingWorks.Repositories.Abstractions.Workers;
using BuildingWorks.Services.Interfaces.Workers;
using Models;

namespace BuildingWorks.Services.Implementations.Workers
{
    public class WorkerService :
        OverviewService<Worker, WorkerResource, WorkerForm, WorkerOverview>,
        IWorkerService
    {
        public WorkerService(BuildingWorksDbContext context, IMapper mapper, IWorkerRepository repository) : base(context, mapper)
        {
            Repository = repository;
        }

        public override IWorkerRepository Repository { get; }

        public IEnumerable<WorkerResource> GetByBrigade(PaginationParameters pagination, int brigadeId)
        {
            return Mapper.Map<IEnumerable<WorkerResource>>(Repository.GetByBrigade(pagination, brigadeId));
        }

        public IEnumerable<WorkerResource> GetByCondition(Condition condition)
        {
            return Mapper.Map<IEnumerable<WorkerResource>>(Repository.GetByCondition(condition));
        }
    }
}
