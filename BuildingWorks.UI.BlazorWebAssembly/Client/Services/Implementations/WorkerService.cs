using BuildingWorks.Models;
using BuildingWorks.Models.Overview;
using BuildingWorks.Models.Resources.Workers;
using BuildingWorks.UI.BlazorWebAssembly.Client.Services.Interfaces;
using Models;
using System.Net.Http.Json;

namespace BuildingWorks.UI.BlazorWebAssembly.Client.Services.Implementations
{
    public class WorkerService : OverviewService<WorkerForm, WorkerResource, WorkerOverview>, IWorkerService
    {
        private readonly HttpClient _http;

        public WorkerService(HttpClient http) : base(http, "workers")
        {
            _http = http;
        }

        public async Task<IEnumerable<WorkerResource>> GetByBrigade(PaginationParameters pagination, int brigadeCode)
        {
            var entities = await _http.GetFromJsonAsync<IEnumerable<WorkerResource>>($"{Path}?brigadeCode={brigadeCode}");

            return entities;
        }

        public async Task<IEnumerable<WorkerResource>> GetByCondition(Condition condition)
        {
            var entities = await _http.GetFromJsonAsync<IEnumerable<WorkerResource>>($"{Path}?getBycondition?PropertyName={condition.PropertyName}&CompatibleValue={condition.CompatibleValue}");

            if (entities == null)
            {
                throw new Exception();
            }

            return entities;
        }
    }
}
