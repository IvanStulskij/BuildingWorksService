using BuildingWorksBackend.Services.Interfaces;
using BuildingWorksService.Services.Interfaces;
using Models.Repositories.Abstractions.Plans;
using Models.Repositories.Abstractions.Providers;
using Models.Repositories.Implementations.Plans;
using Models.Repositories.Implementations.Providers;
using Models.Services;
using Models.Services.Implementations;

namespace BuildingWorksService.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IProviderService, ProviderService>();
            services.AddScoped<IPlanService, PlanService>();
        }

        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IPlanRepository, PlanRepository>();
            services.AddScoped<IProviderRepository, ProviderRepository>();
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
