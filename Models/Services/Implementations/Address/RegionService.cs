using AutoMapper;
using BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address;
using BuildingWorks.Models.Services.Interfaces.BuildingObjects;
using Models;
using Models.Repositories.Abstractions.Addresses;
using Models.Resources.BuildingObject.Addresses;

namespace BuildingWorks.Models.Services.Implementations.Addresses
{
    public class RegionService : Service<Region, RegionResource, RegionForm>, IRegionService
    {
        public RegionService(BuildingWorksDbContext context, Mapper mapper) : base(context, mapper)
        {
        }

        public override IRegionRepository Repository { get; }
    }
}
