using BuildingWorks.Models.Databasable.Tables.Providers;
using System.ComponentModel.DataAnnotations;

namespace BuildingWorks.Models.Databasable.Tables.Provides
{
    public class Material : IProvidersNamespaceRecord
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal PricePerOne { get; set; }
        public string Measure { get; set; }

        public virtual ICollection<Contract> Contracts { get; set; }
    }
}