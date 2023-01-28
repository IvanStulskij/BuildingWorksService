using BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address;
using BuildingWorks.Models.Databasable.Tables.Provides;
using Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace BuildingWorks.Models.Databasable.Tables.BuildingObjects
{
    public class BuildingObject : ITableRecord, IPersistable<int>
    {
        [Key]
        public int Id { get; set; }
        public string ObjectName { get; set; }
        public string ObjectType { get; set; }
        public string ObjectCustomer { get; set; }

        public int RegionId { get; set; }
        public virtual Region Region { get; set; }

        public int TownId { get; set; }
        public virtual Town Town { get; set; }

        public int StreetId { get; set; }
        public virtual Street Street { get; set; }

        public virtual ICollection<ContractsByMaterials> Contracts { get; set; }
    }
}
