using BuildingWorks.Models.Overview;
using BuildingWorks.Models.Resources.BuildingObject;
using BuildingWorks.UI.BlazorWebAssembly.Client.Services.Interfaces;
using System.Net.Http.Json;

namespace BuildingWorks.UI.BlazorWebAssembly.Client.Services.Implementations
{
    public class BuildingObjectService : OverviewService<BuildingObjectForm, BuildingObjectResource, BuildingObjectOverview>, IBuildingObjectService
    {
        private readonly HttpClient _http;

        public BuildingObjectService(HttpClient http) : base(http, "building-objects")
        {
        }

        public async Task<float> CountPrice(int objectId)
        {
            return await _http.GetFromJsonAsync<float>($"/countPrice?objectId={objectId}");
        }
    }
}
