using AutoMapper;
using BuildingWorks.Databasable.Entities.Providers;
using BuildingWorks.Models.Overview;
using BuildingWorks.Models.Resources.Providers;

namespace BuildingWorks.Profilers.Profilers.Providers
{
    public class ProvidersProfiler : Profile
    {
        public ProvidersProfiler()
        {
            CreateMap<Provider, ProviderResource>().ReverseMap();
            CreateMap<Provider, ProviderForm>().ReverseMap();
            CreateMap<Provider, ProviderOverview>().ReverseMap()
                .ForMember(x => x.Name, c => c.MapFrom(x => x.Name))
                .ForMember(x => x.AdditionalData, c => c.MapFrom(x => x.AdditionalData))
                .ForMember(x => x.Country, c => c.MapFrom(x => x.Country));
        }
    }
}