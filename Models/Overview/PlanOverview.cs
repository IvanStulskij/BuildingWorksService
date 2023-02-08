namespace BuildingWorks.Models.Overview
{
    public class PlanOverview
    {
        public DateTime CompleteTime { get; set; }

        public bool IsCompleted { get; set; }

        public decimal Cost { get; set; }

        public string? PathToImage { get; set; }

        public string ObjectName { get; set; }
    }
}