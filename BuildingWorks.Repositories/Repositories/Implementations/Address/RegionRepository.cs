using BuildingWorks.Databasable;
using BuildingWorks.Databasable.Entities.BuildingObjects.Address;
using BuildingWorks.Repositories.Repositories.Abstractions.Addresses;
using Microsoft.EntityFrameworkCore;

namespace BuildingWorks.Repositories.Implementations.Address
{
    public class RegionRepository : Repository<Region, int>, IRegionRepository
    {
        public RegionRepository(BuildingWorksDbContext context) : base(context)
        {
        }

        public async Task<Region> GetById(int id)
        {
            return await _context.Regions.FirstOrDefaultAsync(region => region.Id == id);
        }
    }
}