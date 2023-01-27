using BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address;
using Models.Contexts;
using Models.Repositories.Abstractions.Addresses;

namespace Models.Repositories.Implementations.Address
{
    public class TownRepository : Repository<Town, int>, ITownRepository
    {
        public TownRepository(BuildingWorksDbContext context) : base(context)
        {
        }
    }
}
