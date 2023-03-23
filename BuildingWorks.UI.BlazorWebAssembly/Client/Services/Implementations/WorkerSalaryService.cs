using BuildingWorks.Models.Resources.Workers;
using BuildingWorks.UI.BlazorWebAssembly.Client.Services.Interfaces;
using System.Net.Http.Json;

namespace BuildingWorks.UI.BlazorWebAssembly.Client.Services.Implementations
{
    public class WorkerSalaryService : Service<WorkerSalaryForm, WorkerSalaryResource>, IWorkerSalaryService
    {
        private readonly HttpClient _http;

        public WorkerSalaryService(HttpClient http) : base(http, "workers-salaries")
        {
            _http = http;
        }

        public async Task<float> GetTotalByObject(int objectId)
        {
            return await _http.GetFromJsonAsync<float>($"/getTotalByObject?objectId={objectId}");
        }
    }
}
