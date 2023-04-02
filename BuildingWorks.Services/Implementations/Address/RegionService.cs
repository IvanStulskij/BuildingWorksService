using AutoMapper;
using BuildingWorks.Databasable;
using BuildingWorks.Databasable.Entities.BuildingObjects.Address;
using BuildingWorks.Models.Resources.BuildingObject.Addresses;
using BuildingWorks.Repositories.Abstractions.Addresses;
using BuildingWorks.Services.Bases;
using BuildingWorks.Services.Interfaces.BuildingObjects;

namespace BuildingWorks.Services.Implementations.Address
{
    public class RegionService : Service<Region, RegionResource, RegionForm>, IRegionService
    {
        public RegionService(BuildingWorksDbContext context, IMapper mapper, IRegionRepository repository) : base(context, mapper)
        {
            Repository = repository;
        }

        public override IRegionRepository Repository { get; }
    }
}