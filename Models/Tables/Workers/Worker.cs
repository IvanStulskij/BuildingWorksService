using Models.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuildingWorks.Models.Databasable.Tables.Workers
{
    public class Worker : IPersistable<int>
    {
        [Key]
        public int PersonnelNumber { get; set; }
        public string FullName { get; set; }
        public DateTime StartWorkDate { get; set; }
        public string WorkerPost { get; set; }

        public int BrigadeCode { get; set; }
        public Brigade Brigade { get; set; }

        public List<WorkerSalary> WorkersSalaries { get; set; }

        [NotMapped]
        public int Id { get; set; }
    }
}
