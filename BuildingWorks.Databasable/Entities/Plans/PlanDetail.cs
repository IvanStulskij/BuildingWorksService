using BuildingWorks.Common.Extensions;
using BuildingWorks.Models.Databasable.Tables;
using System.ComponentModel.DataAnnotations;

namespace BuildingWorks.Databasable.Entities.Plans
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
