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
        public override IWorkerRepository Repository { get; }

        public WorkerService(BuildingWorksDbContext context, Mapper mapper) : base(context, mapper)
        {
        }

        public IEnumerable<Worker> GetBrigadeWorkers(int brigadeCode)
        {
            return Repository.GetBrigadeWorkers(brigadeCode);
        }

        public IEnumerable<Worker> GetByCondition(Condition condition)
        {
            return Repository.GetByCondition(condition);
        }
    }
}
