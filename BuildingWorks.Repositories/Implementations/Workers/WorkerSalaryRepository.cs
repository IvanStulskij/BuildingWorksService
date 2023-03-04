using BuildingWorks.Databasable;
using BuildingWorks.Databasable.Entities.Workers;
using BuildingWorks.Repositories.Abstractions.Workers;

namespace BuildingWorks.Repositories.Implementations.Workers
{
    public class WorkerSalaryRepository : Repository<WorkerSalary, int>, IWorkerSalaryRepository
    {
        public WorkerSalaryRepository(BuildingWorksDbContext context) : base(context)
        {
        }

        public float GetObjectTotalSalaries(int objectCode)
        {
            IEnumerable<Brigade> brigades = _context.Brigades.Where(brigade => brigade.ObjectId == objectCode);
            float totalSalariesAmount = 0;

            foreach (var brigade in brigades)
            {
                foreach (var worker in brigade.Workers)
                {
                    IEnumerable<WorkerSalary> workerSalaries = worker.WorkersSalaries;
                    float workerSalaryByPeriod = 0;

                    if (workerSalaries != null)
                    {
                        foreach (var salaryData in workerSalaries)
                        {
                            workerSalaryByPeriod += salaryData.TotalAmount;
                        }
                    }

                    totalSalariesAmount += workerSalaryByPeriod;
                }
            }

            return totalSalariesAmount;
        }
    }
}
