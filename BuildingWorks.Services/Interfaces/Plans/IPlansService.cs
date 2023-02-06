using BuildingWorks.Databasable.Entities.Plans;
using BuildingWorks.Models.Resources.Plans;
using Models;

namespace BuildingWorks.Services.Interfaces.Plans
{
    public interface IPlanService : IService<PlanResource, PlanForm>
    {
        Task<IEnumerable<string>> GetPropertiesNames();

        Task<IEnumerable<Plan>> GetByCondition(Condition condition, string tableName);
    }
}