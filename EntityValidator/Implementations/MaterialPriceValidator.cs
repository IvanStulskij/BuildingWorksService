using BuildingWorks.EntityValidator.Abstractions;
using BuildingWorks.Models.Resources.Providers;
using FluentValidation;

namespace BuildingWorks.EntityValidator.Implementations
{
    public class MaterialPriceValidator : EntityValidator<MaterialsPriceResource>
    {
        public MaterialPriceValidator()
        {
            RuleFor(x => x.Amount)
                .GreaterThan(0);
        }
    }
}
