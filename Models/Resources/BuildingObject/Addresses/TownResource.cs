using Models.Interfaces;

namespace Models.Resources.BuildingObject.Addresses
{
    public class TownResource : TownForm, IResource
    {
        public int Id { get; set; }
    }

    public class TownForm
    {
        public string TownName { get; set; }

        public string RegionName { get; set; }
    }
}
