using AutoMapper;
using BuildingWorks.Databasable;
using BuildingWorks.Models.Databasable.Tables.BuildingObjects;
using BuildingWorks.Models.Resources.BuildingObject;
using BuildingWorks.Repositories.Abstractions.BuildingObjects;
using BuildingWorks.Services.Interfaces.BuildingObjects;

namespace BuildingWorks.Services.Implementations.BuildingObjects
{
    public class BuildingObjectService : Service<BuildingObject, BuildingObjectResource, BuildingObjectForm>, IBuildingObjectService
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
