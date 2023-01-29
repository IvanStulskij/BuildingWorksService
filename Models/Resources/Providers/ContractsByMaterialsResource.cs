using Models.Interfaces;

namespace BuildingWorks.Models.Resources.Providers
{
    public class ContractsByMaterialsResource : ContractsByMaterialForm, IResource
    {
        public int Id { get; set; }
    }

    public class ContractsByMaterialForm
    {
        public int Amount { get; set; }

        public int ContractId { get; set; }

        public int MaterialId { get; set; }
    }
}
