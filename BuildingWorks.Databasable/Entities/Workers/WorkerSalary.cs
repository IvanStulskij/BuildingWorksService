using BuildingWorks.Common.Extensions;
using BuildingWorks.Common.GlobalConstants;
using BuildingWorks.Common.GlobalConstants.ErrorMessages;
using System.ComponentModel.DataAnnotations;

namespace BuildingWorks.Databasable.Entities.Workers
{
    public class WorkerSalary : IPersistable<int>
    {
        [Key]
        public int Id { get; set; }

        public float BaseSalary { get; set; }

        public float Experience { get; set; }

        [Required]
        [Range(0, WorkerSalaryConstants.ChildenCountMax, ErrorMessage = WorkerSalariesErrorMessages.ManyChildrenCountMessage)]
        public int ChildrenCount { get; set; }

        [Required]
        [Range(WorkerSalaryConstants.WorkedDaysMin, WorkerSalaryConstants.WorkedDaysMax, ErrorMessage = WorkerSalariesErrorMessages.WorkedDaysMaxErrorMessage)]
        public int WorkedDays { get; set; }

        public float TotalAmount { get; set; }

        public int WorkerId { get; set; }
        public virtual Worker Worker { get; set; }
    }
}
