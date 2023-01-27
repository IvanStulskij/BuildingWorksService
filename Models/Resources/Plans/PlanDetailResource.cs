using Models.Interfaces;

namespace Models.Resources.Plans
{
    public class PlanDetailResource : IResource
    {
        public int Id { get; set; }

        public int PlanDetailCode { get; set; }
    }

    public class PlanDetailForm
    {
        public string WorkPart { get; set; }

        public bool IsCompleted { get; set; }

        public float Price { get; set; }

        public string Plan { get; set; }
    }
}
