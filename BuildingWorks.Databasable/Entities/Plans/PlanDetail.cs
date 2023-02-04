using Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace BuildingWorks.Models.Databasable.Tables.Plans
{
    public class PlanDetail : ITableRecord, IPersistable<int>
    {
        [Key]
        public int Id { get; set; }
        public string WorkPart { get; set; }
        public bool IsCompleted { get; set; }
        public float Price { get; set; }

        public int PlanId { get; set; }
        public Plan Plan { get; set; }
    }
}
