namespace BuildingWorks.Models.Services.Interfaces
{
    public interface IService<TResource, TResourceForm> where TResource : class
    {
        Task<IEnumerable<TResource>> GetAll();

        Task<TResource> GetById(int id);

        Task<TResource> Create(TResourceForm form);

        Task<TResource> Update(int id, TResourceForm form);

        Task<TResource> Delete(int id);
    }
}