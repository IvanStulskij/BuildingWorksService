using BuildingWorks.Common.Extensions;
using BuildingWorks.Databasable.Entities.BuildingObjects.Address;
using BuildingWorks.Databasable.Entities.Providers;
using BuildingWorks.Models.Types;
using System.ComponentModel.DataAnnotations;

namespace BuildingWorks.Models.Databasable.Tables.BuildingObjects
{
    public class BuildingObject : ITableRecord, IPersistable<int>, IValidatableObject
    {
        [Key]
        public int Id { get; set; }
        public string ObjectName { get; set; }
        public string ObjectType { get; set; }
        public string ObjectCustomer { get; set; }

        public int RegionId { get; set; }
        public virtual Region Region { get; set; }

        public int TownId { get; set; }
        public virtual Town Town { get; set; }

        public int StreetId { get; set; }
        public virtual Street Street { get; set; }

        public virtual ICollection<ContractsByMaterials> Contracts { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var errorMessage = $"The type of builidng object should require any of building object types";

            if (!BuildingObjectTypes.Types.Contains(ObjectType))
            {
                yield return new ValidationResult(errorMessage);
            }
        }
    }
}
