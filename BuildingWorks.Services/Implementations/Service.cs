using AutoMapper;
using BuildingWorks.Models.Databasable;
using Microsoft.EntityFrameworkCore;
using Models;
using BuildingWorks.Databasable;
using BuildingWorks.Common.Extensions;
using BuildingWorks.Repositories.Repositories.Abstractions;
using BuildingWorks.Services.Interfaces;
using BuildingWorks.Databasable.Entities.Plans;

namespace BuildingWorks.Services.Implementations
{
    public abstract class Service<T, TResource, TForm> : IService<TResource, TForm>
        where T : class, IPersistable<int>
        where TResource: class
        where TForm: class

    {
        protected readonly IMapper Mapper;
        protected readonly BuildingWorksDbContext Context;

        public abstract IRepository<T, int> Repository { get; }

        public Service(BuildingWorksDbContext context, Mapper mapper)
        {
            Mapper = mapper;
            Context = context;
        }

        public async Task<TResource> Create(TForm form)
        {
            var entity = Mapper.Map<T>(form);
            entity = await Insert(entity);
            await Context.SaveChangesAsync();
            return Mapper.Map<TResource>(entity);
        }

        public async Task<TResource> Delete(int id)
        {
            var entity = await Find(id);
            Repository.Delete(entity);
            await Context.SaveChangesAsync();
            return Mapper.Map<TResource>(entity);
        }

        public async Task<IEnumerable<TResource>> GetAll()
        {
            return await Repository
                .Get()
                .OrderBy(x => x.Id)
                .ProjectTo<TResource>(Mapper)
                .ToListAsync();
        }

        public async Task<TResource> GetById(int id)
        {
            return Mapper.Map<TResource>(Repository.GetById(id));
        }

        public async Task<TResource> Update(int id, TForm form)
        {
            var entity = await Find(id);
            entity = await Repository.Update(Mapper.Map<T>(form));
            await Context.SaveChangesAsync();
            return Mapper.Map<TResource>(entity);
        }

        protected virtual async ValueTask<T> Insert(T entity)
        {
            entity = await Repository.Insert(entity);
            return entity;
        }

        protected async ValueTask<T> Find(int id)
        {
            var entity = await Context.FindAsync<T>(id);
            if (entity is null)
                throw new Exception("Resource does not exist.");

            return entity;
        }
    }

    public abstract class ConditionalService<T, TResource, TForm> : Service<T, TResource, TForm>
        where T : class, IPersistable<int>
        where TResource : class
        where TForm : class
    {
        private readonly DbSet<T> _set;

        public ConditionalService(BuildingWorksDbContext context, Mapper mapper) : base(context, mapper)
        {
            _set = context.Set<T>();
        }

        public async Task<IEnumerable<Plan>> GetByCondition(Condition condition, string tableName)
        {
            var conditionalSelectQuery = new TemplateConditionalSelectQuery
                (
                    tableName,
                    condition.PropertyName,
                    condition.CompatibleValue
                );

            return await Context
                .Plans
                .FromSqlRaw(conditionalSelectQuery.Query)
                .ToListAsync();
        }
    }
}
