using Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address
{
    public class Town : ITableRecord, IPersistable<int>
    {
        [Key]
        public int Id { get; set; }
        public string TownName { get; set; }

        public int RegionId { get; set; }
        public Region Region { get; set; }
        
        public ICollection<Street> Streets { get; set; }
    }
}