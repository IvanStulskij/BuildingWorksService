using BuildingWorks.EntityValidator.Abstractions;
using BuildingWorks.Models.Resources.BuildingObject;
using BuildingWorks.Models.Types;
using FluentValidation;

namespace BuildingWorks.EntityValidator.Implementations
{
    public class BuildingObjectValidator : EntityValidator<BuildingObjectResource>
    {
        public BuildingObjectValidator() : base()
        {
            RuleFor(x => x.ObjectType)
                .Must(BuildingObjectTypes.Types.Contains);
        }
    }
}
