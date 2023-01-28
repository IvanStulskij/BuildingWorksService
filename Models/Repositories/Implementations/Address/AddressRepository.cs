using BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address;
using Microsoft.EntityFrameworkCore;
using Models.Repositories.Abstractions.Addresses;

namespace Models.Repositories.Implementations.Address
{
    public class AddressRepository : Repository<ObjectAddress, int>, IAddressRepository
    {
        public AddressRepository(BuildingWorksDbContext context) : base(context)
        {
        }

        public async Task<ObjectAddress> GetById(int id)
        {
            return await _context.ObjectAddress.FirstOrDefaultAsync(address => address.Id == id);
        }

        public async Task<ObjectAddress> GetByPosition(string regionName, string townName, string streetName)
        {
            return await _context.ObjectAddress
                .Include(address => address.Town)
                .Include(address => address.Region)
                .Include(address => address.Street)
                .Where(address => address.Region.RegionName == regionName)
                .Where(address => address.Town.TownName == townName)
                .Where(address => address.Street.StreetName == streetName)
                .FirstOrDefaultAsync();
        }
    }
}
