using BuildingWorks.Models.Resources.Providers;

namespace BuildingWorks.Services.Interfaces.Providers
{
    public interface IMaterialsPriceService : IService<MaterialsPriceResource, MaterialsPriceForm>
    {
        IEnumerable<MaterialsPriceForm> GetByObject(int objectId);

        float CountPrice(int objectId);
    }
}
