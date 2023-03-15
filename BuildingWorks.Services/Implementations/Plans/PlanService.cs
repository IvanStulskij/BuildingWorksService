using AutoMapper;
using BuildingWorks.Common.Extensions;
using BuildingWorks.Databasable;
using BuildingWorks.Databasable.Entities.Plans;
using BuildingWorks.Models;
using BuildingWorks.Models.Overview;
using BuildingWorks.Models.Resources.Plans;
using BuildingWorks.Repositories.Abstractions.Plans;
using BuildingWorks.Services.Interfaces.Plans;

namespace BuildingWorks.Services.Implementations.Plans
{
    public class PlanService :
        ConditionalService<Plan, PlanResource, PlanForm>,
        IPlanService
    {
        public PlanService(BuildingWorksDbContext context, IMapper mapper, IPlanRepository repository) : base(context, mapper)
        {
            Repository = repository;
        }

        public override IPlanRepository Repository { get; }

        public async Task<IEnumerable<PlanOverview>> GetAllOverview(PaginationParameters pagination)
        {
            return Repository
                .Get(pagination)
                .OrderBy(x => x.Id)
                .ProjectTo<PlanOverview>(Mapper);
        }

        public async Task<IEnumerable<string>> GetPropertiesNames()
        {
            return Context.Plans
                .EntityType
                .GetProperties()
                .Select(property => property.Name);
        }
    }
}