using BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address;
using Microsoft.EntityFrameworkCore;
using Models.Repositories.Abstractions.Addresses;

namespace Models.Repositories.Implementations.Address
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
