using AutoMapper;
using BuildingWorks.Databasable.Entities.Providers;
using BuildingWorks.Models.Resources.Providers;

namespace BuildingWorks.Profilers.Profilers.Providers
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
