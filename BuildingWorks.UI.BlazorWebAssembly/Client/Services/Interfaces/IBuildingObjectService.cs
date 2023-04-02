using BuildingWorks.Models.Overview;
using BuildingWorks.Models.Resources.BuildingObject;

namespace BuildingWorks.UI.BlazorWebAssembly.Client.Services.Interfaces
{
    public interface IBuildingObjectService : IOverviewService<BuildingObjectForm, BuildingObjectResource, BuildingObjectOverview>
    {
    }
}
