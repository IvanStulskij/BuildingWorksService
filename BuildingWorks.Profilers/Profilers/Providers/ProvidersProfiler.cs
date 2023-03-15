using BuildingWorks.Databasable.Entities.Providers;
using BuildingWorks.Models.Overview;
using BuildingWorks.Models.Resources.Providers;

namespace BuildingWorks.Profilers.Profilers.Providers
{
    public class ProvidersProfiler : BaseOverviewProfiler<Provider, ProviderForm, ProviderResource, ProviderOverview>
    {
        protected override void ConfigureOverviewProfiling()
        {
            CreateMap<Provider, ProviderOverview>().ReverseMap()
                .ForMember(x => x.Name, c => c.MapFrom(x => x.Name))
                .ForMember(x => x.AdditionalData, c => c.MapFrom(x => x.AdditionalData))
                .ForMember(x => x.Country, c => c.MapFrom(x => x.Country));
        }
    }
}