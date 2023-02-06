using BuildingWorks.Databasable.Entities.Providers;

namespace BuildingWorks.Repositories.Abstractions.Providers
{
    public interface IMaterialPriceRepository : IRepository<ContractsByMaterials, int>
    {
        float GetMaterialsPrice(int objectId);

        IEnumerable<ContractsByMaterials> GetMaterialsContracts(int objectId);
    }
}