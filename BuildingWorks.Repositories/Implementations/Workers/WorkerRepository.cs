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

        public IEnumerable<Worker> GetByBrigade(int brigadeId)
        {
            return Get().Where(worker => worker.BrigadeId == brigadeId);
        }

        public IEnumerable<Worker> GetByCondition(Condition conditition)
        {
            string propertyName = conditition.PropertyName;
            string compatibleValue = conditition.CompatibleValue;

            var conditionalSelectQuery = new TemplateConditionalSelectQuery(TablesNames.WorkersTableName, propertyName, compatibleValue);

            return _context.Workers.FromSqlRaw(conditionalSelectQuery.Query).AsEnumerable();
        }
    }
}
