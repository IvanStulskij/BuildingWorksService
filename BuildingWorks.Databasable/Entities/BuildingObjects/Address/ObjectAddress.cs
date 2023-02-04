using Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address
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