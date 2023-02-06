using BuildingWorks.Common.Extensions;
using System.ComponentModel.DataAnnotations;

namespace BuildingWorks.Databasable.Entities.Providers
{
    public class Material : IProvidersNamespaceRecord, IPersistable<int>
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal PricePerOne { get; set; }
        public string Measure { get; set; }

        public virtual ICollection<Contract> Contracts { get; set; }
    }
}