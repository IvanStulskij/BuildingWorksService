using BuildingWorks.Models.Databasable.Tables.BuildingObjects;
using BuildingWorks.Databasable.Entities.Providers;
using System.ComponentModel.DataAnnotations;
using BuildingWorks.Models.Databasable.Tables;
using BuildingWorks.Models.Databasable.Tables.Provides;
using BuildingWorks.Common.Extensions;

namespace BuildingWorks.Databasable.Entities.Provides
{
    public class ContractsByMaterials : ITableRecord, IPersistable<int>
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