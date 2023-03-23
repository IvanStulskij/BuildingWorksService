using BuildingWorks.Models.Resources.Workers;

namespace BuildingWorks.UI.BlazorWebAssembly.Client.Services.Interfaces
{
    public interface IWorkerSalaryService : IService<WorkerSalaryForm, WorkerSalaryResource>
    {
        Task<float> GetTotalByObject(int objectId);
    }
}
