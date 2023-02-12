using BuildingWorks.Databasable;
using BuildingWorks.Databasable.Entities.BuildingObjects.Address;
using BuildingWorks.Repositories.Abstractions.Addresses;

namespace BuildingWorks.Repositories.Implementations.Address
{
    public class RegionRepository : Repository<Region, int>, IRegionRepository
    {
        public RegionRepository(BuildingWorksDbContext context) : base(context)
        {
        }
    }
}