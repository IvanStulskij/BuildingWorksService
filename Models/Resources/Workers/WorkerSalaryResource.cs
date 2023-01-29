using Models.Interfaces;

namespace Models.Resources.Workers
{
    public class WorkerSalaryResource : WorkerSalaryForm, IPersistable<int>
    {
        public int Id { get; set; }
    }

    public class WorkerSalaryForm
    {
        public float BaseSalary { get; set; }

        public float Experience { get; set; }

        public int ChildenCount { get; set; }

        public int WorkedDays { get; set; }

        public float TotalAmount { get; set; }
    }
}
