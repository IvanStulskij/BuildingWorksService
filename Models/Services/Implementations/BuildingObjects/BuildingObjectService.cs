using AutoMapper;
using BuildingWorks.Models.Databasable.Tables.BuildingObjects;
using BuildingWorks.Models.Services.Interfaces.BuildingObjects;
using Models;
using Models.Repositories.Abstractions.BuildingObjects;
using Models.Resources.BuildingObject;

namespace BuildingWorks.Models.Services.Implementations.BuildingObjects
{
    public class BuildingObjectService : Service<BuildingObject, BuildingObjectResource, BuildingObjectForm>, IBuildingObjectService
    {
        public BuildingObjectService(BuildingWorksDbContext context, Mapper mapper) : base(context, mapper)
        {
        }

        public override IBuildingObjectRepository Repository { get; }
    }
}
