using AutoMapper;
using BuildingWorks.Models.Databasable.Tables.Provides;
using BuildingWorks.Models.Resources.Providers;
using BuildingWorks.Models.Services.Interfaces.Providers;
using Models;
using Models.Repositories.Abstractions.Providers;

namespace BuildingWorks.Models.Services.Implementations.Providers
{
    public class MaterialsPriceService : Service<ContractsByMaterials, ContractsByMaterialsResource, ContractsByMaterialForm>,
        IContractsByMaterialService
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
