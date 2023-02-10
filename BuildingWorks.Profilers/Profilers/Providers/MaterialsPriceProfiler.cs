using AutoMapper;
using BuildingWorks.Databasable.Entities.Providers;
using BuildingWorks.Models.Resources.Providers;

namespace BuildingWorks.Profilers.Profilers.Providers
{
    public class MaterialsPriceProfiler : Profile
    {
        public MaterialsPriceProfiler()
        {
            CreateMap<ContractsByMaterials, MaterialsPriceForm>().ReverseMap();
            CreateMap<ContractsByMaterials, MaterialsPriceResource>().ReverseMap();
        }
    }
}
