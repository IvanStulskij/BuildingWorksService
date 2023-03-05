using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Models;
using BuildingWorks.Databasable;
using BuildingWorks.Common.Extensions;
using BuildingWorks.Services.Interfaces;
using BuildingWorks.Databasable.Entities.Plans;
using BuildingWorks.Repositories.Abstractions;
using BuildingWorks.Models;
using BuildingWorks.Common.Exceptions;

namespace BuildingWorks.Services.Implementations
{
    public abstract class Service<T, TResource, TForm> : IService<TResource, TForm>
        where T : class, IPersistable<int>
        where TResource: class, IResource
        where TForm: class

    {
        protected readonly IMapper Mapper;
        protected readonly BuildingWorksDbContext Context;

        public abstract IRepository<T, int> Repository { get; }

        public Service(BuildingWorksDbContext context, IMapper mapper)
        {
            Mapper = mapper;
            Context = context;
        }

        public async Task<TResource> Create(TForm form)
        {
            if (form == null)
            {
                throw new EntityNotFoundException();
            }

            var entity = Mapper.Map<T>(form);
            entity = await Insert(entity);

            await Context.SaveChangesAsync();
            return Mapper.Map<TResource>(entity);
        }

        public async Task<TResource> Delete(int id)
        {
            var entity = await Find(id);

            if (entity == null)
            {
                throw new EntityNotFoundException();
            }

            await Repository.Delete(entity);
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
            var entity = await Repository.GetById(id);

            if (entity == null)
            {
                throw new EntityNotFoundException();
            }

            return Mapper.Map<TResource>(entity);
        }

        public async Task<TResource> Update(TResource resource)
        {
            var entity = await Find(resource.Id);

            if (entity == null)
            {
                throw new EntityNotFoundException();
            }

            entity = await Repository.Update(Mapper.Map<T>(resource));
            await Context.SaveChangesAsync();
            return Mapper.Map<TResource>(entity);
        }

        protected virtual async ValueTask<T> Insert(T entity)
        {
            if (entity == null)
            {
                throw new EntityNotFoundException();
            }

            entity = await Repository.Insert(entity);
            return entity;
        }

        protected async ValueTask<T> Find(int id)
        {
            var entity = await Context.FindAsync<T>(id);
            if (entity is null)
            {
                throw new EntityNotFoundException();
            }

            return entity;
        }
    }

    public abstract class ConditionalService<T, TResource, TForm> : Service<T, TResource, TForm>
        where T : class, IPersistable<int>
        where TResource : class, IResource
        where TForm : class

    {
        private readonly DbSet<T> _set;

        public ConditionalService(BuildingWorksDbContext context, IMapper mapper) : base(context, mapper)
        {
            _set = context.Set<T>();
        }

        public IEnumerable<T> GetByCondition(Condition condition, string tableName)
        {
            var conditionalSelectQuery = new TemplateConditionalSelectQuery
                (
                    tableName,
                    condition.PropertyName,
                    condition.CompatibleValue
                );

            return _set
                .FromSqlRaw(conditionalSelectQuery.Query)
                .AsNoTracking();
        }
    }
}
