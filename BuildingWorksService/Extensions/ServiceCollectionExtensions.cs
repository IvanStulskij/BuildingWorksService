﻿using BuildingWorks.Repositories.Abstractions.Addresses;
using BuildingWorks.Repositories.Abstractions.BuildingObjects;
using BuildingWorks.Repositories.Abstractions.Plans;
using BuildingWorks.Repositories.Abstractions.Providers;
using BuildingWorks.Repositories.Abstractions.Workers;
using BuildingWorks.Repositories.Implementations.Address;
using BuildingWorks.Repositories.Implementations.BuildingObjects;
using BuildingWorks.Repositories.Implementations.Plans;
using BuildingWorks.Repositories.Implementations.Providers;
using BuildingWorks.Repositories.Implementations.Workers;
using BuildingWorks.Services;
using BuildingWorks.Services.Implementations.Address;
using BuildingWorks.Services.Implementations.BuildingObjects;
using BuildingWorks.Services.Implementations.Plans;
using BuildingWorks.Services.Implementations.Providers;
using BuildingWorks.Services.Implementations.Workers;
using BuildingWorks.Services.Interfaces.BuildingObjects;
using BuildingWorks.Services.Interfaces.Plans;
using BuildingWorks.Services.Interfaces.Providers;
using BuildingWorks.Services.Interfaces.Workers;
using FluentValidation;

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
            services.AddScoped<IContractsByMaterialsRepository, ContractsByMaterialsRepository>();
            services.AddScoped<IWorkerRepository, WorkerRepository>();
            services.AddScoped<IBrigadeRepository, BrigadeRepository>();
            services.AddScoped<IWorkerSalaryRepository, WorkerSalaryRepository>();
            services.AddScoped<IBuildingObjectRepository, BuildingObjectRepository>();
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<IRegionRepository, RegionRepository>();
            services.AddScoped<ITownRepository, TownRepository>();
            services.AddScoped<IStreetRepository, StreetRepository>();
        }

        public static void AddAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(AssemblyInfo.MappingTypes);
        }

        public static void AddValidation(this IServiceCollection services)
        {
            services.AddValidatorsFromAssembly(typeof(AssemblyInfo.ValidationTypes).Assembly);
        }
    }
}