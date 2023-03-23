using BuildingWorks.Models.Resources.BuildingObject.Addresses;

namespace BuildingWorks.UI.BlazorWebAssembly.Client.Services.Interfaces
{
    public interface IAddressService : IService<AddressForm, AddressResource>
    {
        Task<AddressResource> GetByPosition(string region, string town, string street);
    }
}