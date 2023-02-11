using System.ComponentModel.DataAnnotations;
using BuildingWorks.Models.Databasable.Tables.BuildingObjects;
using BuildingWorks.Models.Types;

namespace BuildingWorks.Databasable.ValidationAttributes
{
    public class ObjectTypeAttribute : ValidationAttribute
    {
        public BuildingObject BuildingObject { get; set; }

        public string Error => $"The type of the object should require that ";

        public ObjectTypeAttribute(BuildingObject buildingObject)
        {
            BuildingObject = buildingObject;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var buildingObject = (BuildingObject)validationContext.ObjectInstance;
            
            if (!BuildingObjectTypes.Types.Contains(buildingObject.ObjectType))
            {
                return new ValidationResult(Error);
            }

            return ValidationResult.Success;
        }
    }
}
