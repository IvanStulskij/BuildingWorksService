using BuildingWorks.Databasable;
using BuildingWorks.Databasable.Entities.BuildingObjects.Address;
using BuildingWorks.Repositories.Repositories.Abstractions.Addresses;
using Microsoft.EntityFrameworkCore;

namespace BuildingWorks.Repositories.Implementations.Address
{
    public class StreetRepository : Repository<Street, int>, IStreetRepository
    {
        public StreetRepository(BuildingWorksDbContext context) : base(context)
        {
        }

        public async Task<Street> GetById(int id)
        {
            return await _context.Streets.FirstOrDefaultAsync(street => street.Id == id);
        }
    }
}
