using AutoMapper;
using BuildingWorks.Databasable;
using BuildingWorks.Databasable.Entities.Providers;
using BuildingWorks.Models.Resources.Providers;
using BuildingWorks.Repositories.Abstractions.Providers;
using BuildingWorks.Services.Bases;
using BuildingWorks.Services.Interfaces.Providers;

namespace BuildingWorks.Services.Implementations.Providers
{
    public class MaterialsPriceService : Service<ContractsByMaterials, MaterialsPriceResource, MaterialsPriceForm>,
        IMaterialsPriceService
    {
        public MaterialsPriceService(BuildingWorksDbContext context, IMapper mapper, IContractsByMaterialsRepository repository) : base(context, mapper)
        {
            Repository = repository;
        }

        public override IContractsByMaterialsRepository Repository { get; }

        public float CountPrice(int objectId)
        {
            return Repository.CountPrice(objectId);
        }

        public IEnumerable<MaterialsPriceForm> GetByObject(int objectId)
        {
            return Mapper.Map<IEnumerable<MaterialsPriceForm>>(Repository.GetByObject(objectId));
        }
    }
}