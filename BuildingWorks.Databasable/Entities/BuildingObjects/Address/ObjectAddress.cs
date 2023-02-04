using BuildingWorks.Common.Extensions;
using BuildingWorks.Models.Databasable.Tables;
using System.ComponentModel.DataAnnotations;

namespace BuildingWorks.Databasable.Entities.BuildingObjects.Address
{
    public class ObjectAddress : ITableRecord, IPersistable<int>
    {
        [Key]
        public int Id { get; set; }

        public int RegionId { get; set; }
        public Region Region { get; set; }

        public int TownId { get; set; }
        public Town Town { get; set; }

        public int StreetId { get; set; }
        public Street Street { get; set; }
    }
}