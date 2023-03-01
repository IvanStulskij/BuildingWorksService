using BuildingWorks.Databasable;
using BuildingWorks.Databasable.Entities.Providers;
using BuildingWorks.Repositories.Abstractions.Providers;
using Microsoft.EntityFrameworkCore;

namespace BuildingWorks.Repositories.Implementations.Providers
{
    public class MaterialsPriceRepository : Repository<ContractsByMaterials, int>, IMaterialPriceRepository
    {
        public MaterialsPriceRepository(BuildingWorksDbContext context) : base(context)
        {
        }

        public IEnumerable<ContractsByMaterials> GetMaterialsContracts(int objectId)
        {
            return _context.ContractsByMaterials.AsNoTracking()
                .Where(contractPart => contractPart.BuildingObjectId == objectId);
        }

        public float GetMaterialsPrice(int objectId)
        {
            IEnumerable<ContractsByMaterials> contractsByMaterials = GetMaterialsContracts(objectId).AsQueryable()
                .Include(contractPart => contractPart.Material);

            return (float)contractsByMaterials
                .Select(contractsByMaterial => contractsByMaterial.Material.PricePerOne * contractsByMaterial.Amount).Sum();
        }
    }
}
