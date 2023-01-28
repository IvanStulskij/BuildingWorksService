using BuildingWorks.Models.Databasable.Tables.BuildingObjects;
using BuildingWorks.Models.Databasable.Tables.Providers;
using System.ComponentModel.DataAnnotations;

namespace BuildingWorks.Models.Databasable.Tables.Provides
{
    public class ContractsByMaterials : ITableRecord
    {
        [Key]
        public int Id { get; set; }
        public int Amount { get; set; }

        public int BuildingObjectId { get; set; }
        public virtual BuildingObject BuildingObject { get; set; }

        public int ContractId { get; set; }
        public virtual Contract Contract { get; set; }

        public int MaterialId { get; set; }
        public virtual Material Material { get; set; }
    }
}