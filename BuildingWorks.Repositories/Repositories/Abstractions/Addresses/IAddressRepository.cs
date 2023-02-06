using BuildingWorks.Databasable.Entities.BuildingObjects.Address;

namespace BuildingWorks.Repositories.Repositories.Abstractions.Addresses
{
    public interface IAddressRepository : IRepository<ObjectAddress, int>
    {
        Task<ObjectAddress> GetByPosition(string regionName, string townName, string streetName);
    }
}
