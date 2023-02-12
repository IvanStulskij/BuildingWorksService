using System.ComponentModel.DataAnnotations;
using BuildingWorks.Databasable.Entities.Workers;
using BuildingWorks.Models.Types;

namespace BuildingWorks.Databasable.ValidationAttributes
{
    public class WorkerPostsValidationAttribute : ValidationAttribute
    {
        public Worker Worker { get; set; }

        public string Error => "Worker post should be contained in accepted worker posts ";

        public WorkerPostsValidationAttribute(Worker worker)
        {
            Worker = worker;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var worker = (Worker)validationContext.ObjectInstance;

            if (!MaterialsAcceptedMeasures.Measures.Contains(worker.WorkerPost))
            {
                return new ValidationResult(Error);
            }

            return base.IsValid(value, validationContext);
        }
    }
}
