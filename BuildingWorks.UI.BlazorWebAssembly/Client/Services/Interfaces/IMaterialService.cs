using BuildingWorks.Models.Overview;
using BuildingWorks.Models.Resources.Providers;

namespace BuildingWorks.UI.BlazorWebAssembly.Client.Services.Interfaces
{
    public interface IMaterialService : IOverviewService<MaterialForm, MaterialResource, MaterialOverivew>
    {
    }
}
