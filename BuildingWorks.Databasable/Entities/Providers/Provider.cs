using BuildingWorks.Models.Databasable.Tables.Providers;
using Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace BuildingWorks.Models.Databasable.Tables.Provides
{
    public class Provider : IProvidersNamespaceRecord, IPersistable<int>
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string AdditionalData { get; set; }

        public virtual ICollection<Contract> Contracts { get; set; }
    }
}
