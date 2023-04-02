using AutoMapper;
using BuildingWorks.Databasable;
using BuildingWorks.Models.Databasable.Tables.BuildingObjects;
using BuildingWorks.Models.Overview;
using BuildingWorks.Models.Resources.BuildingObject;
using BuildingWorks.Repositories.Abstractions.BuildingObjects;
using BuildingWorks.Services.Bases;
using BuildingWorks.Services.Interfaces.BuildingObjects;

namespace BuildingWorks.Services.Implementations.BuildingObjects
{
    public class BuildingObjectService : OverviewService<BuildingObject, BuildingObjectResource, BuildingObjectForm, BuildingObjectOverview>, IBuildingObjectService
    {
        public BuildingObjectService(
            BuildingWorksDbContext context,
            IMapper mapper,
            IBuildingObjectRepository repository) : base(context, mapper)
        {
            Repository = repository;
        }

        public override IBuildingObjectRepository Repository { get; }
    }
}
