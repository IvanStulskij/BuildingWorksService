using BuildingWorks.Models.Databasable.Tables.BuildingObjects;
using BuildingWorks.Models.Databasable.Tables.Providers;
using System.ComponentModel.DataAnnotations;

namespace BuildingWorks.Models.Databasable.Tables.Provides
{
    public class ContractsByMaterials : ITableRecord
    {
        [Key]
        public int Id { get; set; }

        public int BuildingObjectId { get; set; }
        public BuildingObject BuildingObject { get; set; }

        public int ContractId { get; set; }
        public Contract Contract { get; set; }

        public int MaterialId { get; set; }
        public Material Material { get; set; }
        public int Amount { get; set; }
    }
}