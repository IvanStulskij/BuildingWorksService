using BuildingWorks.Common.Extensions;
using FluentValidation;

namespace BuildingWorks.EntityValidator.Abstractions
{
    public abstract class EntityValidator<TResource> : AbstractValidator<TResource>
        where TResource : IResource
    {
        public EntityValidator()
        {

        }
    }
}
