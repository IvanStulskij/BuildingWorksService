using BuildingWorks.Models.Overview;
using BuildingWorks.Models.Resources.Providers;

namespace BuildingWorks.Services.Interfaces.Providers
{
    public interface IMaterialService : IOverviewService<MaterialResource, MaterialForm, MaterialOverivew>
    {
    }
}
