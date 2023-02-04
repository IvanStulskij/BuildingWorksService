using AutoMapper;
using AutoMapper.QueryableExtensions;
using Models.Extensions;
using Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models.Repositories.Abstractions;

namespace Models.Services
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
            Repository.Delete(entity);
            await Context.SaveChangesAsync();

            return Mapper.Map<TResource>(entity);
        }

        public virtual async Task<TResource> Create(T form)
        {
            var entity = Mapper.Map<T>(form);
            entity = await Insert(entity);

            await Context.SaveChangesAsync();

            return Mapper.Map<TResource>(entity);
        }

        protected async ValueTask<T> Find(int id)
        {
            var entity = await Context.FindAsync<T>(id);

            if (entity is null)
            {
                throw new Exception("Сущность не существует");
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
