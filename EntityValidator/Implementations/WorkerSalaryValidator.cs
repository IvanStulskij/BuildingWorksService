using BuildingWorks.EntityValidator.Abstractions;
using BuildingWorks.Models.Resources.Workers;
using FluentValidation;

namespace BuildingWorks.EntityValidator.Implementations
{
    public class WorkerSalaryValidator : EntityValidator<WorkerSalaryResource>
    {
        public WorkerSalaryValidator() : base()
        {
            RuleFor(x => x.Experience)
                .NotEmpty()
                .InclusiveBetween(0, 50)
                .GreaterThan(0);
            RuleFor(x => x.WorkedDays)
                .InclusiveBetween(1, 31);
            RuleFor(x => x.ChildenCount)
                .InclusiveBetween(1, 10);
        }
    }
}
