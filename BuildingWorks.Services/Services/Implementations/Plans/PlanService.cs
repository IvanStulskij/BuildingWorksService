using AutoMapper;
using BuildingWorks.Models.Databasable.Tables.Plans;
using BuildingWorks.Models.Services.Implementations;
using BuildingWorks.Models.Services.Interfaces.Plans;
using Models.Repositories.Abstractions.Plans;
using Models.Resources.Plans;

namespace Models.Services.Implementations
{
    public class PlanService :
        ConditionalService<Plan, PlanResource, PlanForm>,
        IPlanService
    {
        public PlanService(BuildingWorksDbContext context, Mapper mapper) : base(context, mapper)
        {
        }

        public override IPlanRepository Repository { get; }


        public async Task<IEnumerable<string>> GetPropertiesNames()
        {
            return Context.Plans
                .EntityType
                .GetProperties()
                .Select(property => property.Name);
        }
    }
}