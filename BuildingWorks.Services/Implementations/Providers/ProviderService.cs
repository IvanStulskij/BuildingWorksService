using AutoMapper;
using BuildingWorks.Databasable.Entities.Providers;
using BuildingWorks.Models.Resources.Providers;
using BuildingWorks.Services.Interfaces.Providers;
using BuildingWorks.Databasable;
using BuildingWorks.Repositories.Abstractions.Providers;

namespace BuildingWorks.Services.Implementations.Providers
{
    public class ProviderService :
        Service<Provider, ProviderResource, ProviderForm>,
        IProviderService
    {
        public ProviderService(BuildingWorksDbContext context, IMapper mapper, IProviderRepository repository) : base(context, mapper)
        {
            Repository = repository;
        }

        public override IProviderRepository Repository { get; }
    }
}