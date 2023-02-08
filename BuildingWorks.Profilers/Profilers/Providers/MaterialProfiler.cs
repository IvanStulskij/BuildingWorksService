using AutoMapper;
using BuildingWorks.Databasable.Entities.Providers;
using BuildingWorks.Models.Overview;
using BuildingWorks.Models.Resources.Providers;

namespace BuildingWorks.Profilers.Profilers.Providers
{
    public class MaterialProfiler : Profile
    {
        public MaterialProfiler()
        {
            CreateMap<Material, MaterialForm>().ReverseMap();
            CreateMap<Material, MaterialResource>().ReverseMap();
            CreateMap<Material, MaterialOverivew>()
                .ForMember(x => x.Name, c => c.MapFrom(x => x.Name))
                .ForMember(x => x.Measure, c => c.MapFrom(x => x.Measure))
                .ForMember(x => x.PricePerOne, c => c.MapFrom(x => x.PricePerOne));
        }
    }
}
