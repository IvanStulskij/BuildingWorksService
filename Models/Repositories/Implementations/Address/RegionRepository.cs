using BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address;
using Models.Contexts;
using Models.Repositories.Abstractions.Addresses;

namespace Models.Repositories.Implementations.Address
{
    public class RegionRepository : Repository<Region, int>, IRegionRepository
    {
        public RegionRepository(BuildingWorksDbContext context) : base(context)
        {
        }
    }
}