using BuildingWorks.Common.Extensions;

namespace BuildingWorks.Models.Resources.Plans
{
    public sealed class PlanResource : PlanForm, IResource
    {
        public int Id { get; set; }
    }

    public class PlanForm
    {
        public DateTime CompleteTime { get; set; }
        public bool IsCompleted { get; set; }
        public decimal Cost { get; set; }
        public string PathToImage { get; set; }

        public int ObjectId { get; set; }
    }
}
