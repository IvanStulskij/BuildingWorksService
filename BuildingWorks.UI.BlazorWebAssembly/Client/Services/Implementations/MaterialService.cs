using BuildingWorks.Models.Overview;
using BuildingWorks.Models.Resources.Providers;
using BuildingWorks.UI.BlazorWebAssembly.Client.Services.Interfaces;

namespace BuildingWorks.UI.BlazorWebAssembly.Client.Services.Implementations
{
    public class MaterialService : OverviewService<MaterialForm, MaterialResource, MaterialOverivew>, IMaterialService
    {
        public MaterialService(HttpClient http) : base(http, "materials")
        {
        }
    }
}