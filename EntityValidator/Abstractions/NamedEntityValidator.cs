using BuildingWorks.Models;
using FluentValidation;

namespace EntityValidator.Abstractions
{
    public abstract class NamedEntityValidator<TResource> : AbstractValidator<TResource>
        where TResource : INamedResource
    {
        public NamedEntityValidator()
        {
            RuleFor(x => x.Name)
                .NotNull()
                .NotEmpty();
        }
    }
}
