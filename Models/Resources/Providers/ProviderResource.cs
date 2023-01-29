using Models.Interfaces;

namespace Models.Resources.Providers
{
    public class ProviderResource : ProviderForm, IResource
    {
        public int Id { get; set; }
    }

    public class ProviderForm
    {
        public string Name { get; set; }

        public string Country { get; set; }

        public string AdditionalData { get; set; }
    }
}