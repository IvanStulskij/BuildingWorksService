﻿using AutoMapper;
using BuildingWorks.Databasable;
using BuildingWorks.Databasable.Entities.BuildingObjects.Address;
using BuildingWorks.Models.Resources.BuildingObject.Addresses;
using BuildingWorks.Repositories.Repositories.Abstractions.Addresses;
using BuildingWorks.Services.Interfaces.BuildingObjects;

namespace BuildingWorks.Services.Implementations.BuildingObjects.Addresses
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
