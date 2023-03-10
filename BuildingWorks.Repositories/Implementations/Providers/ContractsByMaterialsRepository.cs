using BuildingWorks.Databasable;
using BuildingWorks.Databasable.Entities.Providers;
using BuildingWorks.Repositories.Abstractions.Providers;
using BuildingWorks.Repositories.Query;

namespace BuildingWorks.Repositories.Implementations.Providers
{
    public class ContractsByMaterialsRepository : Repository<ContractsByMaterials, int>, IContractsByMaterialsRepository
    {
        public ContractsByMaterialsRepository(BuildingWorksDbContext context) : base(context)
        {
        }

        public IEnumerable<ContractsByMaterials> GetMaterialsContracts(int objectId)
        {
            return _context.ContractsByMaterials
                .Where(contractPart => contractPart.BuildingObjectId == objectId);
        }

        public float CountMaterialsPrice(int objectId)
        {
            IEnumerable<ContractsByMaterials> contractsByMaterials = GetMaterialsContracts(objectId).AsQueryable().IncludeMaterials();

            return (float)contractsByMaterials
                .Select(contractsByMaterial => contractsByMaterial.Material.PricePerOne * contractsByMaterial.Amount).Sum();
        }
    }
}