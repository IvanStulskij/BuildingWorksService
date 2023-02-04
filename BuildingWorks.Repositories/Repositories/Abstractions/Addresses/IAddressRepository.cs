using BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address;

namespace Models.Repositories.Abstractions.Addresses
{
    public interface IAddressRepository : IRepository<ObjectAddress, int>
    {
        Task<ObjectAddress> GetByPosition(string regionName, string townName, string streetName);
    }
}
