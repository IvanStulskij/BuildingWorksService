using BuildingWorks.Common.Extensions;
using BuildingWorks.Models.Databasable.Tables;
using System.ComponentModel.DataAnnotations;

namespace BuildingWorks.Databasable.Entities.Registration
{
    public class UnregisteredUserCode : ITableRecord, IPersistable<int>
    {
        [Key]
        public int Id { get; set; }
    }
}
