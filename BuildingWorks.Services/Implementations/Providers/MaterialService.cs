using AutoMapper;
using BuildingWorks.Databasable;
using BuildingWorks.Databasable.Entities.Providers;
using BuildingWorks.Models.Overview;
using BuildingWorks.Models.Resources.Providers;
using BuildingWorks.Repositories.Abstractions.Providers;
using BuildingWorks.Services.Bases;
using BuildingWorks.Services.Interfaces.Providers;

namespace BuildingWorks.Services.Implementations.Providers
{
    public class MaterialService :
        OverviewService<Material, MaterialResource, MaterialForm, MaterialOverivew>,
        IMaterialService
    {
        public MaterialService(BuildingWorksDbContext context, IMapper mapper, IMaterialRepository repository) : base(context, mapper)
        {
            Repository = repository;
        }

        public override IMaterialRepository Repository { get; }
    }
}
