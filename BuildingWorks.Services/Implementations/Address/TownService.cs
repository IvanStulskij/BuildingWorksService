using AutoMapper;
using BuildingWorks.Databasable;
using BuildingWorks.Databasable.Entities.BuildingObjects.Address;
using BuildingWorks.Models.Resources.BuildingObject.Addresses;
using BuildingWorks.Repositories.Repositories.Abstractions.Addresses;
using BuildingWorks.Services.Interfaces.BuildingObjects;

namespace BuildingWorks.Services.Implementations.Address
{
    public class TownService : Service<Town, TownResource, TownForm>, ITownService
    {
        public TownService(BuildingWorksDbContext context, Mapper mapper) : base(context, mapper)
        {
        }

        public override ITownRepository Repository { get; }
    }
}
