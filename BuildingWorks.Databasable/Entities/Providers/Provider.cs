using BuildingWorks.Common.Extensions;
using BuildingWorks.Databasable.Entities.Providers;
using System.ComponentModel.DataAnnotations;

namespace BuildingWorks.Databasable.Entities.Provides
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
