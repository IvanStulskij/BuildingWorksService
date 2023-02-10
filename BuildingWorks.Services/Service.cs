using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using BuildingWorks.Common.Extensions;
using BuildingWorks.Databasable;
using BuildingWorks.Repositories.Abstractions;
using BuildingWorks.Common.Exceptions;

namespace BuildingWorks.Services
{
    public abstract class Service<T, TResource>
        where T : class, IPersistable<int>
        where TResource : class, IResource
    {
        protected readonly IMapper Mapper;
        protected readonly BuildingWorksDbContext Context;

        public abstract IRepository<T, int> Repository { get; }

        public Service(BuildingWorksDbContext context, IMapper mapper)
        {
            Mapper = mapper;
            Context = context;
        }

        public async virtual Task<TResource> GetById(int id)
        {
            var entity = await Repository.GetById(id);

            if (entity == null)
            {
                throw new EntityNotFoundException();
            }

            return Mapper.Map<TResource>(entity);
        }

        public virtual async Task<IEnumerable<TResource>> GetList()
        {
            return await Repository
                .Get()
                .OrderBy(element => element.Id)
                .ProjectTo<TResource>(Mapper)
                .ToListAsync();
        }

        public virtual async Task<TResource> Delete(int id)
        {
            var entity = await Find(id);

            if (entity == null)
            {
                throw new EntityNotFoundException();
            }

            Repository.Delete(entity);
            await Context.SaveChangesAsync();

            return Mapper.Map<TResource>(entity);
        }

        public virtual async Task<TResource> Create(T form)
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

        protected async ValueTask<T> Find(int id)
        {
            var entity = await Context.FindAsync<T>(id);

            if (entity == null)
            {
                throw new EntityNotFoundException();
            }

            return entity;
        }

        protected async virtual ValueTask<T> Insert(T entity)
        {
            entity = await Repository.Insert(entity);
            return entity;
        }
    }
}
