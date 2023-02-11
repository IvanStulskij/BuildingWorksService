using BuildingWorks.Common.Extensions;

namespace BuildingWorks.Models.Resources.BuildingObject
{
    public class BuildingObjectResource : BuildingObjectForm, IResource
    {
        public int Id { get; set; }
    }

    public class BuildingObjectForm
    {
        public string ObjectName { get; set; }

        public string ObjectType { get; set; }

        public string ObjectCustomer { get; set; }

        public int RegionId { get; set; }

        public int TownId { get; set; }

        public int StreetId { get; set; }
    }
}