using BuildingWorks.Common.Extensions;

namespace BuildingWorks.Models.Resources.BuildingObject.Addresses
{
    public class AddressResource : AddressForm, IResource
    {
        public int Id { get; set; }
    }

    public class AddressForm
    {
        public int RegionId { get; set; }

        public int TownId { get; set; }

        public int StreetId { get; set; }
    }
}