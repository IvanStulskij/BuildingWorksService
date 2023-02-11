using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BuildingWorks.Common.Extensions;
using BuildingWorks.Models.Databasable.Tables.BuildingObjects;

namespace BuildingWorks.Databasable.Entities.Workers
{
    public class Brigade : IPersistable<int>
    {
        [Key]
        public int Id { get; set; }

        public int ObjectId { get; set; }
        public virtual BuildingObject Object { get; set; }

        public int BrigadierId { get; set; }
        [NotMapped]
        public virtual Worker Brigadier { get; set; }

        public virtual ICollection<Worker> Workers { get; set; }
    }
}
