namespace BuildingWorks.Models.Overview
{
    public class PlanDetailOverview : Overview
    {
        public string WorkPart { get; set; }

        public bool IsCompleted { get; set; }

        public string Price { get; set; }

        public int PlanId { get; set; }
    }
}