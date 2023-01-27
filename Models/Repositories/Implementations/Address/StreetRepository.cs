using BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address;
using Models.Contexts;
using Models.Repositories.Abstractions.Addresses;

namespace Models.Repositories.Implementations.Address
{
    public class StreetRepository : Repository<Street, int>, IStreetRepository
    {
        public StreetRepository(BuildingWorksDbContext context) : base(context)
        {
        }
    }
}
