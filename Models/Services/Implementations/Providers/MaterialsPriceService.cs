using AutoMapper;
using BuildingWorks.Models.Databasable.Tables.Provides;
using Models;
using Models.Repositories.Abstractions.Providers;
using Models.Resources.Providers;

namespace BuildingWorks.Models.Services.Implementations.Providers
{
    public class MaterialsPriceService : Service<ContractsByMaterials, MaterialResource, MaterialForm>
    {
        public MaterialsPriceService(BuildingWorksDbContext context, Mapper mapper) : base(context, mapper)
        {
        }

        public override IMaterialPriceRepository Repository { get; }
    }
}
