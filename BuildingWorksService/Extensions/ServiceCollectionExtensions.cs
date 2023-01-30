using BuildingWorks.Models.Services.Implementations.Plans;
using BuildingWorks.Models.Services.Implementations.Providers;
using BuildingWorks.Models.Services.Implementations.Workers;
using BuildingWorks.Models.Services.Interfaces.Plans;
using BuildingWorks.Models.Services.Interfaces.Providers;
using BuildingWorks.Models.Services.Interfaces.Workers;
using Models.Repositories.Abstractions.Plans;
using Models.Repositories.Abstractions.Providers;
using Models.Repositories.Abstractions.Workers;
using Models.Repositories.Implementations.Plans;
using Models.Repositories.Implementations.Providers;
using Models.Repositories.Implementations.Workers;
using Models.Services;
using Models.Services.Implementations;

namespace BuildingWorksService.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IPlanService, PlanService>();
            services.AddScoped<IPlanDetailsService, PlanDetailsService>();
            services.AddScoped<IProviderService, ProviderService>();
            services.AddScoped<IMaterialService, MaterialService>();
            services.AddScoped<IMaterialsPriceService, MaterialsPriceService>();
            services.AddScoped<IWorkerService, WorkerService>();
            services.AddScoped<IBrigadeService, BrigadeService>();
            services.AddScoped<IWorkerSalaryService, WorkerSalaryService>();
        }

        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IPlanRepository, PlanRepository>();
            services.AddScoped<IPlanDetailRepository, PlanDetailRepository>();
            services.AddScoped<IProviderRepository, ProviderRepository>();
            services.AddScoped<IMaterialRepository, MaterialsRepository>();
            services.AddScoped<IMaterialPriceRepository, MaterialsPriceRepository>();
            services.AddScoped<IWorkerRepository, WorkerRepository>();
            services.AddScoped<IBrigadeRepository, BrigadeRepository>();
            services.AddScoped<IWorkerSalaryRepository, WorkerSalaryRepository>();
        }

        public static void AddAutoMapper(this IServiceCollection services)
        {
            var assemblyTypes = new[]
            {
                typeof(AssemblyInfo)
            };

            services.AddAutoMapper(assemblyTypes);
        }
    }
}
