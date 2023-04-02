using BuildingWorks.EntityValidator.Abstractions;
using BuildingWorks.Models.Resources.Providers;
using BuildingWorks.Models.Types;
using FluentValidation;

namespace BuildingWorks.EntityValidator.Implementations
{
    public class MaterialValidator : EntityValidator<MaterialResource>
    {
        public MaterialValidator() : base()
        {
            RuleFor(x => x.PricePerOne)
                .GreaterThan(0);
            RuleFor(x => x.Measure)
                .Must(MaterialsAcceptedMeasures.Measures.Contains);
        }
    }
}