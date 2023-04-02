using BuildingWorks.Databasable.Entities.Plans;
using BuildingWorks.Models.Overview;
using BuildingWorks.Models.Resources.Plans;
using BuildingWorks.UI.BlazorWebAssembly.Client.Services.Interfaces;
using Models;
using System.Net.Http.Json;

namespace BuildingWorks.UI.BlazorWebAssembly.Client.Services.Implementations
{
    public class PlanService : OverviewService<PlanForm, PlanResource, PlanOverview>, IPlanService
    {
        private readonly HttpClient _http;

        public PlanService(HttpClient http) : base(http, "plans")
        {
            _http = http;
        }

        public async Task<IEnumerable<Plan>> GetByCondition(Condition condition)
        {
            var plans = await _http.GetFromJsonAsync<IEnumerable<Plan>>($"{Path}/getBycondition?PropertyName={condition.PropertyName}&CompatibleValue={condition.CompatibleValue}");

            if (plans == null)
            {
                throw new Exception("No entities");
            }

            return plans;
        }

        public async Task<IEnumerable<string>> GetPropertiesNames()
        {
            var propertiesNames = await _http.GetFromJsonAsync<IEnumerable<string>>($"{Path}/getPropertiesNames");

            return propertiesNames;
        }
    }
}
