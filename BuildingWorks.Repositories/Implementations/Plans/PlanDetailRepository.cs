using BuildingWorks.Common.Extensions;
using BuildingWorks.Databasable;
using BuildingWorks.Databasable.Entities.Plans;
using BuildingWorks.Models;
using BuildingWorks.Repositories.Abstractions.Plans;

namespace BuildingWorks.Repositories.Implementations.Plans
{
    public class PlanDetailRepository : Repository<PlanDetail, int>, IPlanDetailRepository
    {
        public PlanDetailRepository(BuildingWorksDbContext context) : base(context)
        {
        }

        public float CountDonePercent(int planId)
        {
            IEnumerable<PlanDetail> plansDetails = GetByPlan(planId);
            IEnumerable<PlanDetail> donePlanDetails = GetCompleted(plansDetails);

            float totalCount = Convert.ToSingle(plansDetails.Count());
            float doneCount = Convert.ToSingle(donePlanDetails.Count());

            var planBenefit = new PlanCompletePercent(totalCount, doneCount);

            return MathF.Round(planBenefit.Count() * 100, MathConstants.DigitsToOutput);
        }

        public IEnumerable<PlanDetail> GetByPlan(int planId)
        {
            return _context.PlansDetails
                .Where(planDetail => planDetail.PlanId == planId);
        }

        public IEnumerable<PlanDetail> GetCompleted(IEnumerable<PlanDetail> planDetails)
        {
            return planDetails.Where(planDetail => planDetail.IsCompleted);
        }
    }
}