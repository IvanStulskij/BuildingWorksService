using BuildingWorks.Databasable;
using BuildingWorks.Models.Databasable.Tables.BuildingObjects;
using BuildingWorks.Repositories.Abstractions.BuildingObjects;

namespace BuildingWorks.Repositories.Implementations.BuildingObjects
{
    public class BuildingObjectRepository : Repository<BuildingObject, int>, IBuildingObjectRepository
    {
        public BuildingObjectRepository(BuildingWorksDbContext context) : base(context)
        {
        }
    }
}