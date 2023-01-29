using AutoMapper;
using BuildingWorks.Models.Databasable.Tables.Provides;
using BuildingWorks.Models.Resources.Providers;

namespace BuildingWorks.Models.Profilers.Providers
{
    public class MaterialsPriceProfiler : Profile
    {
        public MaterialsPriceProfiler()
        {
            CreateMap<ContractsByMaterials, ContractsByMaterialForm>().ReverseMap();
            CreateMap<ContractsByMaterials, ContractsByMaterialsResource>().ReverseMap();
        }
    }
}
