using BuildingWorks.Models.Databasable.Tables.Plans;
using BuildingWorks.Models.Services.Interfaces;
using Models;
using Models.Resources.Plans;

namespace BuildingWorksService.Services.Interfaces
{
    public interface IPlanService : IService<PlanResource, PlanForm>
    {
        Task<IEnumerable<string>> GetPropertiesNames();

        Task<IEnumerable<Plan>> GetByCondition(Condition condition, string tableName);
    }
}