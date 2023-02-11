using BuildingWorks.Common.Extensions;

namespace BuildingWorks.Models.Resources.BuildingObject.Addresses
{
    public class StreetResource : StreetForm, IResource
    {
        public int Id { get; set; }

    }

    public class StreetForm
    {
        public string Name { get; set; }

        public int TownId { get; set; }
    }
}