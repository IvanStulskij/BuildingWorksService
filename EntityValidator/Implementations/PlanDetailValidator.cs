using BuildingWorks.EntityValidator.Abstractions;
using BuildingWorks.Models.Resources.Plans;
using FluentValidation;

namespace BuildingWorks.EntityValidator.Implementations
{
    public class PlanDetailValidator : EntityValidator<PlanDetailResource>
    {
        public PlanDetailValidator() : base()
        {
            RuleFor(x => x.Price)
                .GreaterThan(0);
        }
    }
}
