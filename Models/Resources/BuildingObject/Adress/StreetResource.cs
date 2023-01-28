using Models.Interfaces;

namespace Models.Resources.BuildingObject.Adress
{
    public class StreetResource : StreetForm, IResource
    {
        public int Id { get; set; }

    }

    public class StreetForm
    {
        public string Name { get; set; }

        public string TownName { get; set; }
    }
}