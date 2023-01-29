using BuildingWorks.Models.Services.Implementations.Plans;
using BuildingWorks.Models.Services.Interfaces.Plans;
using Models.Repositories.Abstractions.Plans;
using Models.Repositories.Implementations.Plans;
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
            /*services.AddScoped<IProviderService, ProviderService>();
            services.AddScoped<IPlanService, PlanService>();*/
        }

        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IPlanRepository, PlanRepository>();
            services.AddScoped<IPlanDetailRepository, PlanDetailRepository>();
            /*services.AddScoped<IPlanRepository, PlanRepository>();
            services.AddScoped<IProviderRepository, ProviderRepository>();*/
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
