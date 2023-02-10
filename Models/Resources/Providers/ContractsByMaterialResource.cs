using BuildingWorks.Common.Extensions;

namespace BuildingWorks.Models.Resources.Providers
{
    public class MaterialsPriceResource : MaterialsPriceForm, IResource
    {
        public int Id { get; set; }
    }

    public class MaterialsPriceForm
    {
        public int Amount { get; set; }

        public int ContractId { get; set; }

        public int MaterialId { get; set; }
    }
}
