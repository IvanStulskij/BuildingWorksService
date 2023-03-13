using BuildingWorks.Databasable.Entities.Providers;

namespace BuildingWorks.Repositories.Abstractions.Providers
{
    public interface IContractsByMaterialsRepository : IRepository<ContractsByMaterials, int>
    {
        float CountPrice(int objectId);

        IEnumerable<ContractsByMaterials> GetByObject(int objectId);
    }
}