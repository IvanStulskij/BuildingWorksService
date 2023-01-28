using BuildingWorks.Models.Databasable;
using BuildingWorks.Models.Databasable.Tables.Workers;
using Microsoft.EntityFrameworkCore;
using Models.Contexts;
using Models.GlobalConstants;
using Models.Repositories.Abstractions.Workers;

namespace Models.Repositories.Implementations.Workers
{
    public class WorkerRepository : Repository<Worker, int>, IWorkerRepository
    {
        public WorkerRepository(BuildingWorksDbContext context) : base(context)
        {
        }

        public async Task<Worker> GetById(int id)
        {
            return await Get().FirstOrDefaultAsync(worker => worker.Id == id);
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
