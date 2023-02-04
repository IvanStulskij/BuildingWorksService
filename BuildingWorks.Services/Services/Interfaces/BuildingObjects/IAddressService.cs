using BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address;
using Models.Resources.BuildingObject.Addresses;

namespace BuildingWorks.Models.Services.Interfaces.BuildingObjects
{
    public interface IAddressService : IService<AddressResource, AddressForm>
    {
        AddressResource GetByPosition(string regionName, string townName, string streetName);
    }
}
