using BuildingWorks.Common.Extensions;

namespace BuildingWorks.Models.Resources.BuildingObject.Addresses
{
    public class AddressResource : AddressForm, IResource
    {
        public int Id { get; set; }
    }

    public class AddressForm
    {
        public string Region { get; set; }

        public string Town { get; set; }

        public string Street { get; set; }
    }
}