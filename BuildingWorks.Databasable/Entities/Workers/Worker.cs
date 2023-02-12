using System.ComponentModel.DataAnnotations;
using BuildingWorks.Common.Extensions;

namespace BuildingWorks.Databasable.Entities.Workers
{
    public class Worker : IPersistable<int>
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime StartWorkDate { get; set; }
        public string WorkerPost { get; set; }

        public int BrigadeId { get; set; }
        public virtual Brigade Brigade { get; set; }

        public virtual ICollection<WorkerSalary> WorkersSalaries { get; set; }
    }
}