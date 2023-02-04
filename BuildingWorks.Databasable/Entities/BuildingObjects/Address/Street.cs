using BuildingWorks.Common.Extensions;
using BuildingWorks.Models.Databasable.Tables;
using System.ComponentModel.DataAnnotations;

namespace BuildingWorks.Databasable.Entities.BuildingObjects.Address
{
    public class Street : ITableRecord, IPersistable<int>
    {
        [Key]
        public int Id { get; set; }
        public string StreetName { get; set; }

        public int TownId { get; set; }
        public Town Town { get; set; }
    }
}