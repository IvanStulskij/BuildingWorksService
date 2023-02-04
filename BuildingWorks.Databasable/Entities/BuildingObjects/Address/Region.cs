using BuildingWorks.Common.Extensions;
using System.ComponentModel.DataAnnotations;

namespace BuildingWorks.Databasable.Entities.BuildingObjects.Address
{
    public class Region : ITableRecord, IPersistable<int>
    {
        [Key]
        public int Id { get; set; }
        public string RegionName { get; set; }

        public ICollection<Town> Towns { get; set; }
    }
}