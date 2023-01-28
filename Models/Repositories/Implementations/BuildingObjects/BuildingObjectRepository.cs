using BuildingWorks.Models.Databasable.Tables.BuildingObjects;
using Microsoft.EntityFrameworkCore;
using Models.Repositories.Abstractions.BuildingObjects;

namespace Models.Repositories.Implementations.BuildingObjects
{
    public class BuildingObjectRepository : Repository<BuildingObject, int>, IBuildingObjectRepository
    {
        public BuildingObjectRepository(BuildingWorksDbContext context) : base(context)
        {
        }

        public async Task<BuildingObject> GetById(int id)
        {
            return await Get()
                .FirstOrDefaultAsync(buildingObject => buildingObject.ObjectId == id);
        }
    }
}