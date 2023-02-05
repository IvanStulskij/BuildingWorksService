using AutoMapper;
using BuildingWorks.Databasable.Entities.Providers;
using BuildingWorks.Models.Resources.Providers;

namespace BuildingWorks.Profilers.Profilers.Providers
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