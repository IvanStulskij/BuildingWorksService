using BuildingWorks.Models.Databasable.Tables.Provides;
using System.ComponentModel.DataAnnotations;

namespace BuildingWorks.Models.Databasable.Tables.Providers
{
    public class Contract : IProvidersNamespaceRecord
    {
        [Key]
        public int Id { get; set; }
        public string Conditions { get; set; }

        public int ProviderId { get; set; }
        public virtual Provider Provider { get; set; }

        public virtual ICollection<Material> Materials { get; set; }
    }
}