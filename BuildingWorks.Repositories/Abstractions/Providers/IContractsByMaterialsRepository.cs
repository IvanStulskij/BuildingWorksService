using BuildingWorks.Databasable.Entities.Providers;

namespace BuildingWorks.Repositories.Abstractions.Providers
{
    public interface IContractsByMaterialsRepository : IRepository<ContractsByMaterials, int>
    {
        float GetMaterialsPrice(int objectId);

        IEnumerable<ContractsByMaterials> GetMaterialsContracts(int objectId);
    }
}