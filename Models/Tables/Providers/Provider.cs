using Models.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuildingWorks.Models.Databasable.Tables.Provides
{
    public class Provider : IProvidersNamespaceRecord, IPersistable<int>
    {
        [Key]
        public int ProviderCode { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string AdditionalData { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }

        [NotMapped]
        public int Id { get; set; }
    }
}
