using BuildingWorks.Models.Databasable.Tables.Provides;

namespace Models.Repositories.Abstractions.Providers
{
    public interface IMaterialPriceRepository : IRepository<ContractsByMaterials, int>
    {
        float GetMaterialsPrice(int objectId);

        IEnumerable<ContractsByMaterials> GetMaterialsContracts(int objectId);
    }
}