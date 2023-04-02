using BuildingWorks.UI.BlazorWebAssembly.Client.Services.Implementations;
using BuildingWorks.UI.BlazorWebAssembly.Client.Services.Interfaces;

namespace BuildingWorks.UI.BlazorWebAssembly.Client
{
    public static class ServiceExtensions
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IBuildingObjectService, BuildingObjectService>();
            services.AddScoped<IProviderService, ProviderService>();
            services.AddScoped<IPlanService, PlanService>();
            services.AddScoped<IPlanDetailService, PlanDetailService>();
            services.AddScoped<IMaterialService, MaterialService>();
            services.AddScoped<IWorkerService, WorkerService>();
        }
    }
}
