using BuildingWorks.Models.Resources.BuildingObject.Addresses;

namespace BuildingWorks.Services.Interfaces.BuildingObjects
{
    public interface IAddressService : IService<AddressResource, AddressForm>
    {
        AddressResource GetByPosition(string regionName, string townName, string streetName);
    }
}
