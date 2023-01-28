using AutoMapper;
using BuildingWorks.Models.Databasable.Tables.Provides;
using Models.Resources.Providers;
using Models.Repositories.Abstractions.Providers;
using Models;
using BuildingWorks.Models.Services.Interfaces.Providers;

namespace BuildingWorks.Models.Services.Implementations.Providers
{
    public class ProviderService :
        Service<Provider, ProviderResource, ProviderForm>,
        IProviderService
    {
        public ProviderService(BuildingWorksDbContext context, Mapper mapper) : base(context, mapper)
        {
        }

        public override IProviderRepository Repository { get; }
    }
}