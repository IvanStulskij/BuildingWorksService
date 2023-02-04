using Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace BuildingWorks.Models.Databasable.Tables.Registration
{
    public class UnregisteredUserCode : ITableRecord, IPersistable<int>
    {
        [Key]
        public int Id { get; set; }
    }
}
