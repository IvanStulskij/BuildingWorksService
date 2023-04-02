using System.Net.Http.Json;
using BuildingWorks.Databasable.Entities.Plans;
using BuildingWorks.Models.Overview;
using BuildingWorks.Models.Resources.Plans;
using BuildingWorks.UI.BlazorWebAssembly.Client.Services.Interfaces;

namespace BuildingWorks.UI.BlazorWebAssembly.Client.Services.Implementations
{
    public class PlanDetailService : OverviewService<PlanDetailForm, PlanDetailResource, PlanDetailOverview>, IPlanDetailService
    {
        private readonly HttpClient _http;

        public PlanDetailService(HttpClient http) : base(http, "plan-details")
        {
            _http = http;
        }

        public async Task<float> CountDonePercent(int planId)
        {
            return await _http.GetFromJsonAsync<float>($"{Path}/countDonePercent?planId={planId}");
        }

        public async Task<IEnumerable<PlanDetail>> GetByPlan(int planId)
        {
            var planDetails = await _http.GetFromJsonAsync<IEnumerable<PlanDetail>>($"{Path}/getByPlan?planId={planId}");

            if (planDetails == null)
            {
                throw new Exception();
            }

            return planDetails;
        }

        public async Task<IEnumerable<PlanDetail>> GetCompleted(IEnumerable<PlanDetail> planDetails)
        {
            var completed = await _http.PostAsJsonAsync<IEnumerable<PlanDetail>>($"{Path}/getCompleted", planDetails);

            return await completed.Content.ReadFromJsonAsync<IEnumerable<PlanDetail>>();
        }
    }
}
