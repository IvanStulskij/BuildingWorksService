using AutoMapper;
using BuildingWorks.Models.Databasable.Tables.Provides;
using Models.Resources.Providers;

namespace BuildingWorks.Models.Profilers.Providers
{
    public class MaterialProfiler : Profile
    {
        public MaterialProfiler()
        {
            CreateMap<Material, MaterialForm>().ReverseMap();
            CreateMap<Material, MaterialResource>().ReverseMap();
        }
    }
}
