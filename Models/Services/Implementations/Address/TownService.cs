using AutoMapper;
using BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address;
using BuildingWorks.Models.Services.Interfaces.BuildingObjects;
using Models;
using Models.Repositories.Abstractions.Addresses;
using Models.Resources.BuildingObject.Adress;

namespace BuildingWorks.Models.Services.Implementations.Addresses
{
    public class TownService : Service<Town, TownResource, TownForm>, ITownService
    {
        public TownService(BuildingWorksDbContext context, Mapper mapper) : base(context, mapper)
        {
        }

        public override ITownRepository Repository { get; }
    }
}
