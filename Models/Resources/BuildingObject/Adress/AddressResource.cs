using Models.Interfaces;

namespace Models.Resources.BuildingObject.Adress
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