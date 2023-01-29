using Models.Interfaces;

namespace Models.Resources.BuildingObject.Adress
{
    public class RegionResource : RegionForm, IResource 
    {
        public int Id { get; set; }

        public int RegionCode { get; set; }
    }

    public class RegionForm
    {
        public string RegionName { get; set; }
    }
}
