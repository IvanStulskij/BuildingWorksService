using BuildingWorks.Models.Databasable.Tables.Providers;
using Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace BuildingWorks.Models.Databasable.Tables.Provides
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