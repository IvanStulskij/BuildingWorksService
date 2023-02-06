using AutoMapper;
using BuildingWorks.Databasable;
using BuildingWorks.Databasable.Entities.Providers;
using BuildingWorks.Models.Resources.Providers;
using BuildingWorks.Repositories.Abstractions.Providers;
using BuildingWorks.Services.Interfaces.Providers;

namespace BuildingWorks.Services.Implementations.Providers
{
    public class MaterialService :
        Service<Material, MaterialResource, MaterialForm>,
        IMaterialService
    {
        public MaterialService(BuildingWorksDbContext context, Mapper mapper) : base(context, mapper)
        {
        }

        public override IMaterialRepository Repository { get; }
    }
}
