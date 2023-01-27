﻿using BuildingWorks.Models.Databasable.Tables.Provides;
using Microsoft.EntityFrameworkCore;
using Models.Contexts;
using Models.Repositories.Abstractions.Providers;

namespace Models.Repositories.Implementations.Providers
{
    public class MaterialPriceRepository : Repository<ContractsByMaterials, int>, IMaterialPriceRepository
    {
        public MaterialPriceRepository(BuildingWorksDbContext context) : base(context)
        {
        }

        public async Task<ContractsByMaterials> GetById(int id)
        {
            return await Get().FirstOrDefaultAsync(contractByMaterial => contractByMaterial.Id == id);
        }

        public IEnumerable<ContractsByMaterials> GetMaterialsContracts(int objectId)
        {
            return _context.ContractsByMaterials
                .Include(contract => contract.BuildingObject)
                .Where(contractPart => contractPart.BuildingObject.ObjectId == objectId);
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
