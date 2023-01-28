using Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address
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