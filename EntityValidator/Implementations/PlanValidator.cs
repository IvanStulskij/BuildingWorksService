using BuildingWorks.EntityValidator.Abstractions;
using BuildingWorks.Models.Resources.Plans;
using FluentValidation;

namespace BuildingWorks.EntityValidator.Implementations
{
    public class PlanValidator : EntityValidator<PlanResource>
    {
        public PlanValidator() : base()
        {
            RuleFor(x => x.Cost)
                .GreaterThan(0);
        }
    }
}
