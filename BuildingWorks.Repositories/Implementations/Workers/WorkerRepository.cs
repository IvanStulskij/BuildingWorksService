using BuildingWorks.Common.Extensions;
using BuildingWorks.Databasable;
using BuildingWorks.Databasable.Entities.Workers;
using BuildingWorks.Models;
using BuildingWorks.Repositories.Abstractions.Workers;
using Microsoft.EntityFrameworkCore;
using Models;

namespace BuildingWorks.Repositories.Implementations.Workers
{
    public class WorkerRepository : Repository<Worker, int>, IWorkerRepository
    {
        public WorkerRepository(BuildingWorksDbContext context) : base(context)
        {
        }

        public IEnumerable<Worker> GetBrigadeWorkers(int brigadeCode)
        {
            return Get().Where(worker => worker.BrigadeId == brigadeCode);
        }

        public IEnumerable<Worker> GetByCondition(Condition conditition)
        {
            var propertyName = conditition.PropertyName;
            var compatibleValue = conditition.CompatibleValue;

            var conditionalSelectQuery = new TemplateConditionalSelectQuery(TablesNames.WorkersTableName, propertyName, compatibleValue);

            return _context.Workers.FromSqlRaw(conditionalSelectQuery.Query).AsEnumerable();
        }
    }
}
