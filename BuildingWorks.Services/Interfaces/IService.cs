using BuildingWorks.Models;

namespace BuildingWorks.Services.Interfaces
{
    public interface IService<TResource, TResourceForm> where TResource : class
    {
        Task<IEnumerable<TResource>> GetAll(PaginationParameters pagination);

        Task<TResource> GetById(int id);

        Task<TResource> Create(TResourceForm form);

        Task<TResource> Update(TResource resource);

        Task<TResource> Delete(int id);
    }
}