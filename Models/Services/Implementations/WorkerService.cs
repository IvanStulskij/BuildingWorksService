using AutoMapper;
using AutoMapper.QueryableExtensions;
using BuildingWorks.Models.Databasable.Tables.Workers;
using Microsoft.EntityFrameworkCore;
using Models.Contexts;
using Models.Extensions;
using Models.Repositories.Abstractions.Workers;
using Models.Resources.Workers;
using Models.Services.Interfaces;

namespace Models.Services.Implementations
{
    public class WorkerService :
        Service<Worker, WorkerResource>,
        IWorkerService
    {
        public override IWorkerRepository Repository { get; }

        public WorkerService(BuildingWorksDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public Task<List<WorkerResource>> GetAll()
        {
            return Repository.Get().ProjectTo<WorkerResource>(Mapper).ToListAsync();
        }

        public IEnumerable<Worker> GetBrigadeWorkers(int brigadeCode)
        {
            return Repository.GetBrigadeWorkers(brigadeCode);
        }

        public IEnumerable<Worker> GetByCondition(Condition condition)
        {
            return Repository.GetByCondition(condition);
        }

        public async Task<WorkerResource> Create(WorkerForm form)
        {
            var entity = Mapper.Map<Worker>(form);

            return Mapper.Map<WorkerResource>(Repository.Insert(entity));
        }

        public async Task Delete(int codeToDelete)
        {
            var entity = await Context.Workers
                .FirstOrDefaultAsync(worker => worker.Id == codeToDelete);
        }

        public Task<WorkerResource> Update(WorkerResource resource)
        {
            throw new NotImplementedException();
        }
    }
}
