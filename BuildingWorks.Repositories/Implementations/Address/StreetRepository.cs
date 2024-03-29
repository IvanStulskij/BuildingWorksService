﻿using BuildingWorks.Databasable;
using BuildingWorks.Databasable.Entities.BuildingObjects.Address;
using BuildingWorks.Repositories.Abstractions.Addresses;

namespace BuildingWorks.Repositories.Implementations.Address
{
    public class StreetRepository : Repository<Street, int>, IStreetRepository
    {
        public StreetRepository(BuildingWorksDbContext context) : base(context)
        {
        }
    }
}
