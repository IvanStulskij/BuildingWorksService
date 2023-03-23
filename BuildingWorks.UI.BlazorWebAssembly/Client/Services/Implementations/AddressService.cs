using BuildingWorks.Models.Resources.BuildingObject.Addresses;
using BuildingWorks.UI.BlazorWebAssembly.Client.Services.Interfaces;
using System.Net.Http.Json;

namespace BuildingWorks.UI.BlazorWebAssembly.Client.Services.Implementations
{
    public class AddressService : Service<AddressForm, AddressResource>, IAddressService
    {
        private readonly HttpClient _http;

        public AddressService(HttpClient http) : base(http, "addresses")
        {
            _http = http;
        }

        public async Task<AddressResource> GetByPosition(string region, string town, string street)
        {
            AddressResource address = await _http.GetFromJsonAsync<AddressResource>($"/getByPosition?regionName={region};townName={town};street={street}");

            if (address == null)
            {
                throw new Exception("No addresses by presented address found in database");
            }

            return address;
        }
    }
}
