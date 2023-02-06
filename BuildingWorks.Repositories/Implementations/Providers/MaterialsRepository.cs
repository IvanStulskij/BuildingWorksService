using BuildingWorks.Databasable;
using BuildingWorks.Databasable.Entities.Providers;
using BuildingWorks.Repositories.Abstractions.Providers;
using BuildingWorks.Repositories.Implementations;
using Microsoft.EntityFrameworkCore;

namespace BuildingWorks.Repositories.Implementations.Providers
{
    public class MaterialsRepository : Repository<Material, int>, IMaterialRepository
    {
        public MaterialsRepository(BuildingWorksDbContext context) : base(context)
        {
        }

        public async Task<Material> GetById(int id)
        {
            return await _context.Materials.FirstOrDefaultAsync(material => material.Id == id);
        }
    }
}
