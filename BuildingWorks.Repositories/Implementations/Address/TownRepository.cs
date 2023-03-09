using BuildingWorks.Databasable;
using BuildingWorks.Databasable.Entities.BuildingObjects.Address;
using BuildingWorks.Repositories.Abstractions.Addresses;

namespace BuildingWorks.Repositories.Implementations.Address
{
    public class TownRepository : Repository<Town, int>, ITownRepository
    {
        public TownRepository(BuildingWorksDbContext context) : base(context)
        {
        }
    }
}
