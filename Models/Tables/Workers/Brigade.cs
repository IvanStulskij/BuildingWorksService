using System.ComponentModel.DataAnnotations;
using BuildingWorks.Models.Databasable.Tables.BuildingObjects;
using Models.Interfaces;

namespace BuildingWorks.Models.Databasable.Tables.Workers
{
    public class Brigade : IPersistable<int>
    {
        [Key]
        public int Id { get; set; }

        public int ObjectId { get; set; }
        public virtual BuildingObject Object { get; set; }

        public int BrigadierId { get; set; }
        public virtual Worker Brigadier { get; set; }

        public virtual ICollection<Worker> Workers { get; set; }
    }
}
