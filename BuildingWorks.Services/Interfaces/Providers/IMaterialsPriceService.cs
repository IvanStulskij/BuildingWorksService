using BuildingWorks.Models.Resources.Providers;

namespace BuildingWorks.Services.Interfaces.Providers
{
    public interface IMaterialsPriceService : IService<MaterialsPriceResource, MaterialsPriceForm>
    {
        IEnumerable<MaterialsPriceForm> GetMaterialsContracts(int objectId);

        float GetByObject(int objectId);
    }
}
