using AutoMapper;
using BuildingWorks.Models.Databasable.Tables.Workers;
using BuildingWorks.Models.Services.Interfaces.Workers;
using Models;
using Models.Repositories.Abstractions.Workers;
using Models.Resources.Workers;

namespace BuildingWorks.Models.Services.Implementations.Workers
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
