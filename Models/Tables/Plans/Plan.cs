using BuildingWorks.Models.Databasable.Tables.BuildingObjects;
using Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace BuildingWorks.Models.Databasable.Tables.Plans
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