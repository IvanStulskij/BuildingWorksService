using AutoMapper;
using BuildingWorks.Databasable;
using BuildingWorks.Databasable.Entities.Plans;
using BuildingWorks.Models.Resources.Plans;
using BuildingWorks.Repositories.Repositories.Abstractions.Plans;
using BuildingWorks.Services.Interfaces.Plans;

namespace BuildingWorks.Services.Implementations.Plans
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