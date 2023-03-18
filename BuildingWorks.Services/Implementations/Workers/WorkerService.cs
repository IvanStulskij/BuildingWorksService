using AutoMapper;
using BuildingWorks.Databasable;
using BuildingWorks.Databasable.Entities.Workers;
using BuildingWorks.Models;
using BuildingWorks.Models.Overview;
using BuildingWorks.Models.Resources.Workers;
using BuildingWorks.Repositories.Abstractions.Workers;
using BuildingWorks.Services.Bases;
using BuildingWorks.Services.Interfaces.Workers;

namespace BuildingWorks.Services.Implementations.Workers
{
    public class WorkerService :
        ConditionalOverviewService<Worker, WorkerResource, WorkerForm, WorkerOverview>,
        IWorkerService
    {
        public WorkerService(BuildingWorksDbContext context, IMapper mapper, IWorkerRepository repository) : base(context, mapper, )
        {
            Repository = repository;
        }

        public override IWorkerRepository Repository { get; }

        public IEnumerable<WorkerResource> GetByBrigade(PaginationParameters pagination, int brigadeId)
        {
            return Mapper.Map<IEnumerable<WorkerResource>>(Repository.GetByBrigade(pagination, brigadeId));
        }
    }
}
