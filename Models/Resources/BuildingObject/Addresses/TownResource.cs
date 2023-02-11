using BuildingWorks.Common.Extensions;

namespace BuildingWorks.Models.Resources.BuildingObject.Addresses
{
    public class TownResource : TownForm, IResource
    {
        public int Id { get; set; }
    }

    public class TownForm
    {
        public int TownId { get; set; }

        public int RegionId { get; set; }
    }
}
