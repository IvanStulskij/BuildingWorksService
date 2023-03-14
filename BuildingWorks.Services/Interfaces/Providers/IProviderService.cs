using BuildingWorks.Models.Overview;
using BuildingWorks.Models.Resources.Providers;

namespace BuildingWorks.Services.Interfaces.Providers
{
    public interface IProviderService : IOverviewService<ProviderResource, ProviderForm, ProviderOverview>
    {
    }
}