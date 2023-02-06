using BuildingWorks.Common.Extensions;
using BuildingWorks.Models.Databasable.Tables;
using BuildingWorks.Models.Databasable.Tables.BuildingObjects;
using System.ComponentModel.DataAnnotations;

namespace BuildingWorks.Databasable.Entities.Plans
{
    public class Plan : ITableRecord, IPersistable<int>
    {
        [Key]
        public int Id { get; set; }
        public DateTime CompleteTime { get; set; }
        public bool IsCompleted { get; set; }
        public decimal Cost { get; set; }
        public string? PathToImage { get; set; }

        public int ObjectId { get; set; }
        public BuildingObject Object { get; set; }
    }
}