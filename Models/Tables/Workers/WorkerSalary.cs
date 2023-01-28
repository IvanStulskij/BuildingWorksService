using Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace BuildingWorks.Models.Databasable.Tables.Workers
{
    public class WorkerSalary : IPersistable<int>
    {
        [Key]
        public int Id { get; set; }
        public float BaseSalary { get; set; }
        public float Experience { get; set; }
        public int ChildrenCount { get; set; }
        public int WorkedDays { get; set; }
        public float TotalAmount { get; set; }

        public int WorkerId { get; set; }
        public virtual Worker Worker { get; set; }
    }
}
