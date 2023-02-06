using BuildingWorks.Databasable;
using BuildingWorks.Databasable.Entities.BuildingObjects.Address;
using BuildingWorks.Repositories.Repositories.Abstractions.Addresses;
using Microsoft.EntityFrameworkCore;

namespace BuildingWorks.Repositories.Implementations.Address
{
    public class TownRepository : Repository<Town, int>, ITownRepository
    {
        public TownRepository(BuildingWorksDbContext context) : base(context)
        {
        }

        public async Task<Town> GetById(int id)
        {
            return await _context.Towns.FirstOrDefaultAsync(town => town.Id == id);
        }
    }
}
