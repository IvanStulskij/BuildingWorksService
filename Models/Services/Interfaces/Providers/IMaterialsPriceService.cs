using BuildingWorks.Models.Resources.Providers;

namespace BuildingWorks.Models.Services.Interfaces.Providers
{
    public interface IMaterialsPriceService : IService<ContractsByMaterialsResource, ContractsByMaterialForm>
    {
        IEnumerable<ContractsByMaterialForm> GetMaterialsContracts(int objectId);

        float GetMaterialPrice(int objectId);
    }
}
