using Models.Services;

namespace BuildingWorksService.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            /*services.AddScoped<IProviderService, ProviderService>();
            services.AddScoped<IPlanService, PlanService>();*/
        }

        public static void AddRepositories(this IServiceCollection services)
        {
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
