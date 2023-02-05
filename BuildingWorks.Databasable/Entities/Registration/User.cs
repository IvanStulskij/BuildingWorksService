using BuildingWorks.Common.Extensions;
using BuildingWorks.Models.Databasable.Tables;
using System.ComponentModel.DataAnnotations;

namespace BuildingWorks.Databasable.Entities.Registration
{
    public class User : ITableRecord, IPersistable<int>
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }

    }
}