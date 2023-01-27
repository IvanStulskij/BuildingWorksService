using BuildingWorks.Models.Databasable.Tables.Plans;
using Models.Contexts;
using Models.GlobalConstants;
using Models.Repositories.Abstractions.Plans;

namespace Models.Repositories.Implementations.Plans
{
    public class PlanDetailRepository : Repository<PlanDetail, int>, IPlanDetailRepository
    {
        public PlanDetailRepository(BuildingWorksDbContext context) : base(context)
        {
        }

        public float CountDonePercent(int planId)
        {
            IEnumerable<PlanDetail> plansDetails = FindDetailsByPlan(planId);
            IEnumerable<PlanDetail> donePlanDetails = FindDoneDetailsByPlan(plansDetails);

            float totalCount = Convert.ToSingle(plansDetails.Count());
            float doneCount = Convert.ToSingle(donePlanDetails.Count());

            var planBenefit = new PlanCompletePercent(totalCount, doneCount);

            return MathF.Round(planBenefit.Count() * 100, MathConstants.DigitsToOutput);
        }

        public IEnumerable<PlanDetail> FindDetailsByPlan(int planId)
        {
            return _context.PlansDetails
                .Where(planDetail => planDetail.PlanId == planId);
        }

        public IEnumerable<PlanDetail> FindDoneDetailsByPlan(IEnumerable<PlanDetail> planDetails)
        {
            return planDetails.Where(planDetail => planDetail.IsCompleted);
        }

        public Task<PlanDetail> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
