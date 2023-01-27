using BuildingWorks.Models.Databasable.Tables.Plans;
using Models;
using Models.Resources.Plans;

namespace BuildingWorksService.Services.Interfaces
{
    public interface IPlanService
    {
        Task<IEnumerable<PlanResource>> GetAll();

        Task<PlanResource> GetById(int id);

        Task<PlanResource> Delete(int id);

        Task<PlanResource> Create(PlanForm plan);

        Task<PlanResource> Update(int id, PlanForm form);

        Task<IEnumerable<string>> GetPropertiesNames();

        Task<List<Plan>> GetByCondition(Condition condition);
    }
}