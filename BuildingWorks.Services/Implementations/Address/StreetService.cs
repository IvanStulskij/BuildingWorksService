using AutoMapper;
using BuildingWorks.Databasable;
using BuildingWorks.Databasable.Entities.BuildingObjects.Address;
using BuildingWorks.Models.Resources.BuildingObject.Addresses;
using BuildingWorks.Repositories.Abstractions.Addresses;
using BuildingWorks.Services.Bases;
using BuildingWorks.Services.Interfaces.BuildingObjects;

namespace BuildingWorks.Services.Implementations.Address
{
    public class StreetService : Service<Street, StreetResource, StreetForm>, IStreetService
    {
        public StreetService(BuildingWorksDbContext context, IMapper mapper, IStreetRepository repository) : base(context, mapper)
        {
            Repository = repository;
        }

        public override IStreetRepository Repository { get; }
    }
}
