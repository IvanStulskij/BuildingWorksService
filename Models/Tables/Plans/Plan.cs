using BuildingWorks.Models.Databasable.Tables.BuildingObjects;
using Models.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuildingWorks.Models.Databasable.Tables.Plans
{
    public class Plan : ITableRecord, IPersistable<int>
    {
        [Key]
        public int PlanCode { get; set; }
        public DateTime CompleteTime { get; set; }
        public bool IsCompleted { get; set; }
        public decimal Cost { get; set; }
        public string? PathToImage { get; set; }

        public int ObjectId { get; set; }
        public BuildingObject Object { get; set; }

        [NotMapped]
        public int Id { get; set; }
    }
}