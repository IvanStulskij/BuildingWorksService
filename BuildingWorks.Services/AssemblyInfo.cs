using BuildingWorks.EntityValidator.Implementations;
using BuildingWorks.Profilers.Profilers.Addresses;
using BuildingWorks.Profilers.Profilers.BuildingObjects;
using BuildingWorks.Profilers.Profilers.Contracts;
using BuildingWorks.Profilers.Profilers.Plans;
using BuildingWorks.Profilers.Profilers.Providers;
using BuildingWorks.Profilers.Profilers.Workers;

namespace BuildingWorks.Services
{
    public static class AssemblyInfo
    {
        public readonly static Type[] MappingTypes = new []
        {
            typeof(BuildingObjectProfiler),
            typeof(AddressesProfiler),
            typeof(RegionsProfiler),
            typeof(TownsProfiler),
            typeof(StreetsProfiler),
            typeof(PlanDetailsProfiler),
            typeof(PlansProfiler),
            typeof(MaterialProfiler),
            typeof(MaterialsPriceProfiler),
            typeof(ProvidersProfiler),
            typeof(BrigadeProfiler),
            typeof(WorkerSalaryProfiler),
            typeof(WorkersProfiler),
            typeof(ContractsProfiler),
        };


        public readonly static Type[] ValidationTypes = new[]
        {
            typeof(BuildingObjectValidator),
            typeof(MaterialValidator),
            typeof(PlanValidator),
            typeof(WorkerSalaryValidator),
        };
    }
}
