using BuildingWorks.Databasable;
using BuildingWorks.Databasable.Entities.Providers;
using BuildingWorks.Repositories.Implementations;
using BuildingWorks.Repositories.Repositories.Abstractions.Providers;
using Microsoft.EntityFrameworkCore;

namespace BuildingWorks.Repositories.Implementation.Providers
{
    public class MaterialsPriceRepository : Repository<ContractsByMaterials, int>, IMaterialPriceRepository
    {
        public MaterialsPriceRepository(BuildingWorksDbContext context) : base(context)
        {
        }

        public async Task<ContractsByMaterials> GetById(int id)
        {
            return await Get().FirstOrDefaultAsync(contractByMaterial => contractByMaterial.Id == id);
        }

        public IEnumerable<ContractsByMaterials> GetMaterialsContracts(int objectId)
        {
            return _context.ContractsByMaterials
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
