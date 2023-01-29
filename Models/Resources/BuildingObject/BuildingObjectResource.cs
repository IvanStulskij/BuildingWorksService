using Models.Interfaces;

namespace Models.Resources.BuildingObject
{
    public class BuildingObjectResource : BuildingObjectForm, IResource
    {
        public int Id { get; set; }
    }

    public class BuildingObjectForm
    {
        public string ObjectType { get; set; }
        public string ObjectCustomer { get; set; }

        public string Region { get; set; }

        public string Town { get; set; }

        public string Street { get; set; }
    }
}