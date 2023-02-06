using AutoMapper;
using BuildingWorks.Databasable;
using BuildingWorks.Databasable.Entities.BuildingObjects.Address;
using BuildingWorks.Models.Resources.BuildingObject.Addresses;
using BuildingWorks.Repositories.Repositories.Abstractions.Addresses;
using BuildingWorks.Services.Interfaces.BuildingObjects;

namespace BuildingWorks.Services.Implementations.BuildingObjects.Addresses
{
    public class RegionService : Service<Region, RegionResource, RegionForm>, IRegionService
    {
        public RegionService(BuildingWorksDbContext context, Mapper mapper) : base(context, mapper)
        {
        }

        public override IRegionRepository Repository { get; }
    }
}
