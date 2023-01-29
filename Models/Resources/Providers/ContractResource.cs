using Models.Interfaces;

namespace Models.Resources.Providers
{
    public class ContractResource : ContractForm, IResource
    {
        public int Id { get ; set; }
    }

    public class ContractForm
    {
        public string Conditions { get; set; }

        public string Provider { get; set; }
    }
}
