using AutoMapper;
using BuildingWorks.Databasable;
using BuildingWorks.Common.Extensions;
using BuildingWorks.Services.Interfaces;
using BuildingWorks.Databasable.Entities.Plans;
using BuildingWorks.Repositories.Abstractions;
using BuildingWorks.Models;
using BuildingWorks.Common.Exceptions;

namespace BuildingWorks.Services.Bases
{
    public abstract class Service<T, TResource, TForm> : IService<TResource, TForm>
        where T : class, IPersistable<int>
        where TResource : class, IResource
        where TForm : class

    {
        protected readonly IMapper Mapper;

        public abstract IRepository<T, int> Repository { get; }

        public Service(IMapper mapper)
        {
            Mapper = mapper;
        }

        public async Task<TResource> Create(TForm form)
        {
            if (form == null)
            {
                throw new EntityNotFoundException();
            }

            T entity = Mapper.Map<T>(form);
            entity = await Insert(entity);

            return Mapper.Map<TResource>(entity);
        }

        public async Task<TResource> Delete(int id)
        {
            T entity = await Find(id);

            if (entity == null)
            {
                throw new EntityNotFoundException();
            }

            await Repository.Delete(entity);
            return Mapper.Map<TResource>(entity);
        }

        public async Task<IEnumerable<TResource>> GetAll(PaginationParameters pagination)
        {
            return Repository
                .Get(pagination)
                .OrderBy(x => x.Id)
                .ProjectTo<TResource>(Mapper);
        }

        public async Task<TResource> GetById(int id)
        {
            T entity = await Repository.GetById(id);

            if (entity == null)
            {
                throw new EntityNotFoundException();
            }

            return Mapper.Map<TResource>(entity);
        }

        public async Task<TResource> Update(TResource resource)
        {
            T entity = await Repository.GetById(resource.Id);

            if (entity == null)
            {
                throw new EntityNotFoundException();
            }

            entity = await Repository.Update(Mapper.Map<T>(resource));

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
    }
}