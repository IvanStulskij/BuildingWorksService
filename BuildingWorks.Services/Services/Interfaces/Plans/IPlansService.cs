using BuildingWorks.Models.Databasable.Tables.Plans;
using Models;
using Models.Resources.Plans;

namespace BuildingWorks.Models.Services.Interfaces.Plans
{
    public interface IPlanService : IService<PlanResource, PlanForm>
    {
        Task<IEnumerable<string>> GetPropertiesNames();

        Task<IEnumerable<Plan>> GetByCondition(Condition condition, string tableName);
    }
}