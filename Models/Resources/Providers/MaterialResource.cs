using BuildingWorks.Common.Extensions;

namespace BuildingWorks.Models.Resources.Providers
{
    public class MaterialResource : MaterialForm, IResource
    {
        public int Id { get; set; }
    }

    public class MaterialForm
    {
        public string Name { get; set; }

        public decimal PricePerOne { get; set; }

        public string Measure { get; set; }
    }
}