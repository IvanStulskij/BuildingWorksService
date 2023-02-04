using BuildingWorks.Models.Databasable.Tables.Provides;
using Microsoft.EntityFrameworkCore;
using Models.Repositories.Abstractions.Providers;

namespace Models.Repositories.Implementations.Providers
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
