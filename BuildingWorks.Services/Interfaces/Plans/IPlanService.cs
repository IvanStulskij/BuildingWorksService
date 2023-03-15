using BuildingWorks.Databasable.Entities.Plans;
using BuildingWorks.Models.Overview;
using BuildingWorks.Models.Resources.Plans;
using Models;

namespace BuildingWorks.Services.Interfaces.Plans
{
    public interface IPlanService : IOverviewService<PlanResource, PlanForm, PlanOverview>
    {
        Task<IEnumerable<string>> GetPropertiesNames();

        IEnumerable<Plan> GetByCondition(Condition condition, string tableName);
    }
}