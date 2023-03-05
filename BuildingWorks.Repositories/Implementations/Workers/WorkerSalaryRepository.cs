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

        public float GetTotalSalaries(int objectCode)
        {
            IEnumerable<Brigade> brigades = _context.Brigades.Where(brigade => brigade.ObjectId == objectCode);
            float totalSalariesAmount = 0;

            foreach (Brigade brigade in brigades)
            {
                foreach (Worker worker in brigade.Workers)
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
