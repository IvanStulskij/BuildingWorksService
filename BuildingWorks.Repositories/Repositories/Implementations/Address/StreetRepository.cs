using BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address;
using Microsoft.EntityFrameworkCore;
using Models.Repositories.Abstractions.Addresses;

namespace Models.Repositories.Implementations.Address
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
