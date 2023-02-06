using AutoMapper;
using BuildingWorks.Databasable;
using BuildingWorks.Databasable.Entities.BuildingObjects.Address;
using BuildingWorks.Models.Resources.BuildingObject.Addresses;
using BuildingWorks.Repositories.Repositories.Abstractions.Addresses;
using BuildingWorks.Services.Interfaces.BuildingObjects;

namespace BuildingWorks.Services.Implementations.BuildingObjects.Addresses
{
    public class StreetService : Service<Street, StreetResource, StreetForm>, IStreetService
    {
        public StreetService(BuildingWorksDbContext context, Mapper mapper) : base(context, mapper)
        {
        }

        public override IStreetRepository Repository { get; }
    }
}
