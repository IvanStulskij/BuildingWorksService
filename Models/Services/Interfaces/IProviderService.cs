using BuildingWorks.Models.Databasable.Tables.Provides;
using Models.Resources.Providers;

namespace BuildingWorksBackend.Services.Interfaces
{
    public interface IProviderService
    {
        Task<List<ProviderResource>> GetAll();

        Task<ProviderResource> GetById(int id);

        Task<ProviderResource> Delete(int id);

        Task<ProviderResource> Create(ProviderForm provider);

        Task<Provider> Update(ProviderResource provider);
    }
}