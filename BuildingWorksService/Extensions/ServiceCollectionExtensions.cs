using BuildingWorks.Models.Services.Implementations.Addresses;
using BuildingWorks.Models.Services.Implementations.BuildingObjects;
using BuildingWorks.Models.Services.Implementations.Plans;
using BuildingWorks.Models.Services.Implementations.Providers;
using BuildingWorks.Models.Services.Implementations.Workers;
using BuildingWorks.Models.Services.Interfaces.BuildingObjects;
using BuildingWorks.Models.Services.Interfaces.Plans;
using BuildingWorks.Models.Services.Interfaces.Providers;
using BuildingWorks.Models.Services.Interfaces.Workers;
using Models.Repositories.Abstractions.Addresses;
using Models.Repositories.Abstractions.Plans;
using Models.Repositories.Abstractions.Providers;
using Models.Repositories.Abstractions.Workers;
using Models.Repositories.Implementations.Address;
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
            services.AddScoped<IBuildingObjectService, BuildingObjectService>();
            services.AddScoped<IAddressService, AddressService>();
            services.AddScoped<IRegionService, RegionService>();
            services.AddScoped<ITownService, TownService>();
            services.AddScoped<IStreetService, StreetService>();
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
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<IRegionRepository, RegionRepository>();
            services.AddScoped<ITownRepository, TownRepository>();
            services.AddScoped<IStreetRepository, StreetRepository>();
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