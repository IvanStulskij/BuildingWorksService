using AutoMapper;
using BuildingWorks.Databasable;
using BuildingWorks.Databasable.Entities.Providers;
using BuildingWorks.Models.Resources.Providers;
using BuildingWorks.Repositories.Repositories.Abstractions.Providers;
using BuildingWorks.Services.Interfaces.Providers;

namespace BuildingWorks.Services.Implementations.Providers
{
    public class MaterialsPriceService : Service<ContractsByMaterials, ContractsByMaterialResource, ContractsByMaterialForm>,
        IMaterialsPriceService
    {
        public MaterialsPriceService(BuildingWorksDbContext context, Mapper mapper) : base(context, mapper)
        {
        }

        public override IMaterialPriceRepository Repository { get; }

        public float GetMaterialPrice(int objectId)
        {
            return Repository.GetMaterialsPrice(objectId);
        }

        public IEnumerable<ContractsByMaterialForm> GetMaterialsContracts(int objectId)
        {
            return Mapper.Map<IEnumerable<ContractsByMaterialForm>>(Repository.GetMaterialsContracts(objectId));
        }
    }
}
