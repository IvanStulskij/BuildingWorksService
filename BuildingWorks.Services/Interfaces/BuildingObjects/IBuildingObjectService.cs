using BuildingWorks.Models.Overview;
using BuildingWorks.Models.Resources.BuildingObject;

namespace BuildingWorks.Services.Interfaces.BuildingObjects
{
    public interface IBuildingObjectService : IOverviewService<BuildingObjectResource, BuildingObjectForm, BuildingObjectOverview>
    {
    }
}