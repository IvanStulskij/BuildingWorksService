using AutoMapper;
using AutoMapper.QueryableExtensions;
using BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address;
using BuildingWorks.Models.Services.Interfaces.BuildingObjects;
using Models;
using Models.Repositories.Abstractions.Addresses;
using Models.Resources.BuildingObject.Addresses;

namespace BuildingWorks.Models.Services.Implementations.Addresses
{
    public class AddressService : Service<ObjectAddress, AddressResource, AddressForm>, IAddressService
    {
        public AddressService(BuildingWorksDbContext context, Mapper mapper) : base(context, mapper)
        {
        }

        public override IAddressRepository Repository { get; }

        public AddressResource GetByPosition(string regionName, string townName, string streetName)
        {
            return Mapper.Map<AddressResource>(Repository.GetByPosition(regionName, townName, streetName));
        }
    }
}
