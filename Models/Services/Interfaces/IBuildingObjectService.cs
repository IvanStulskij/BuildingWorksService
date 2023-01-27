using BuildingWorks.Models.Databasable.Tables.Provides;
using Models.Resources.BuildingObject;
using Models.Resources.Providers;

namespace Models.Services.Interfaces
{
    public interface IBuildingObjectService
    {
        Task<List<BuildingObjectResource>> GetAll();

        Task<ProviderResource> GetById(int id);

        Task<ProviderResource> Delete(int id);

        Task<ProviderResource> Create(ProviderForm provider);

        Task<Provider> Update(ProviderResource provider);
    }
}