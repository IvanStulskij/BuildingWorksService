using BuildingWorks.Common.Extensions;
using BuildingWorks.Databasable;
using BuildingWorks.Databasable.Entities.Plans;
using BuildingWorks.Repositories.Repositories.Abstractions.Plans;
using Microsoft.EntityFrameworkCore;
using Models;

namespace BuildingWorks.Repositories.Implementations.Plans
{
    public class PlanDetailRepository : Repository<PlanDetail, int>, IPlanDetailRepository
    {
        public PlanDetailRepository(BuildingWorksDbContext context) : base(context)
        {
        }

        public float CountDonePercent(int planId)
        {
            IEnumerable<PlanDetail> plansDetails = FindByPlan(planId);
            IEnumerable<PlanDetail> donePlanDetails = FindCompleted(plansDetails);

            float totalCount = Convert.ToSingle(plansDetails.Count());
            float doneCount = Convert.ToSingle(donePlanDetails.Count());

            var planBenefit = new PlanCompletePercent(totalCount, doneCount);

            return MathF.Round(planBenefit.Count() * 100, MathConstants.DigitsToOutput);
        }

        public IEnumerable<PlanDetail> FindByPlan(int planId)
        {
            return _context.PlansDetails
                .Where(planDetail => planDetail.PlanId == planId);
        }

        public IEnumerable<PlanDetail> FindCompleted(IEnumerable<PlanDetail> planDetails)
        {
            return planDetails.Where(planDetail => planDetail.IsCompleted);
        }

        public async Task<PlanDetail> GetById(int id)
        {
            return await _context.PlansDetails.FirstOrDefaultAsync(planDetail => planDetail.Id == id);
        }
    }
}
