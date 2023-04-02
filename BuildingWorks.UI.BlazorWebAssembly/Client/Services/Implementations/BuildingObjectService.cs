using BuildingWorks.Models.Overview;
using BuildingWorks.Models.Resources.BuildingObject;
using BuildingWorks.UI.BlazorWebAssembly.Client.Services.Interfaces;

namespace BuildingWorks.UI.BlazorWebAssembly.Client.Services.Implementations
{
    public class BuildingObjectService : OverviewService<BuildingObjectForm, BuildingObjectResource, BuildingObjectOverview>, IBuildingObjectService
    {
        public BuildingObjectService(HttpClient http) : base(http, "building-objects")
        {
        }
    }
}
