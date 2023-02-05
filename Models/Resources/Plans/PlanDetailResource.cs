using BuildingWorks.Common.Extensions;

namespace BuildingWorks.Models.Resources.Plans
{
    public class PlanDetailResource : PlanDetailForm, IResource
    {
        public int Id { get; set; }
    }

    public class PlanDetailForm
    {
        public string WorkPart { get; set; }

        public bool IsCompleted { get; set; }

        public float Price { get; set; }

        public string Plan { get; set; }
    }
}
