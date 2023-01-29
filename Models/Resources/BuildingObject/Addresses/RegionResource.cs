using Models.Interfaces;

namespace Models.Resources.BuildingObject.Addresses
{
    public class RegionResource : RegionForm, IResource 
    {
        public int Id { get; set; }
    }

    public class RegionForm
    {
        public string RegionName { get; set; }
    }
}
