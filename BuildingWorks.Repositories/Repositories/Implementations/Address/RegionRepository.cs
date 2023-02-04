using BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address;
using Microsoft.EntityFrameworkCore;
using Models.Repositories.Abstractions.Addresses;

namespace Models.Repositories.Implementations.Address
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