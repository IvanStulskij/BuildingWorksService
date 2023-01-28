using Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address
{
    public class Region : ITableRecord, IPersistable<int>
    {
        [Key]
        public int Id { get; set; }
        public string RegionName { get; set; }

        public ICollection<Town> Towns { get; set; }
    }
}