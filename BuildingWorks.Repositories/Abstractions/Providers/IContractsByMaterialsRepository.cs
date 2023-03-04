using BuildingWorks.Databasable.Entities.Providers;

namespace BuildingWorks.Repositories.Abstractions.Providers
{
    public interface IContractsByMaterialsRepository : IRepository<ContractsByMaterials, int>
    {
        float CountMaterialsPrice(int objectId);

        IEnumerable<ContractsByMaterials> GetMaterialsContracts(int objectId);
    }
}