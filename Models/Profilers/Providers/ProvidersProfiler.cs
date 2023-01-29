using AutoMapper;
using BuildingWorks.Models.Databasable.Tables.Provides;
using Models.Resources.Providers;

namespace BuildingWorks.Models.Profilers.Providers
{
    public class ProvidersProfiler : Profile
    {
        public ProvidersProfiler()
        {
            CreateMap<Provider, ProviderResource>().ReverseMap();
            CreateMap<Provider, ProviderForm>().ReverseMap();
        }
    }
}