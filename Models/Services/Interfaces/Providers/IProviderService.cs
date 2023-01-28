using Models.Resources.Providers;

namespace BuildingWorks.Models.Services.Interfaces.Providers
{
    public interface IProviderService
    {
        Task<IEnumerable<ProviderResource>> GetAll();

        Task<ProviderResource> GetById(int id);

        Task<ProviderResource> Delete(int id);

        Task<ProviderResource> Create(ProviderForm provider);

        Task<ProviderResource> Update(int id, ProviderForm provider);
    }
}