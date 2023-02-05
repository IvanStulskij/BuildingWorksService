using AutoMapper;
using BuildingWorks.Databasable.Entities.Providers;
using BuildingWorks.Models.Resources.Providers;

namespace BuildingWorks.Profilers.Profilers.Providers
{
    public class MaterialsPriceProfiler : Profile
    {
        public MaterialsPriceProfiler()
        {
            CreateMap<ContractsByMaterials, ContractsByMaterialForm>().ReverseMap();
            CreateMap<ContractsByMaterials, ContractsByMaterialResource>().ReverseMap();
        }
    }
}
