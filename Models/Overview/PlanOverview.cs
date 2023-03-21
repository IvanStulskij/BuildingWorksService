namespace BuildingWorks.Models.Overview
{
    public class PlanOverview : Overview
    {
        public string CompleteTime { get; set; }

        public bool IsCompleted { get; set; }

        public string Cost { get; set; }

        public string? PathToImage { get; set; }

        public string ObjectName { get; set; }
    }
}