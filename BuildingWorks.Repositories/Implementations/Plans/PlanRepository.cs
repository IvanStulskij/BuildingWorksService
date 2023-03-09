using BuildingWorks.Databasable;
using BuildingWorks.Databasable.Entities.Plans;
using BuildingWorks.Repositories.Abstractions.Plans;

namespace BuildingWorks.Repositories.Implementations.Plans
{
    public class PlanRepository : Repository<Plan, int>, IPlanRepository 
    {
        public PlanRepository(BuildingWorksDbContext context) : base(context)
        {
        }
    }
}
