using System.ComponentModel.DataAnnotations;
using BuildingWorks.Databasable.Entities.Providers;
using BuildingWorks.Models.Types;

namespace BuildingWorks.Databasable.ValidationAttributes
{
    public class MaterialMeasureValidationAttibute : ValidationAttribute
    {
        public Material Material { get; set; }

        public string Error => $"Material measure should be contained in accepted collection";

        public MaterialMeasureValidationAttibute(Material material)
        {
            Material = material;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var material = (Material)validationContext.ObjectInstance;

            if (!MaterialsAcceptedMeasures.Measures.Contains(material.Measure))
            {
                return new ValidationResult(Error);
            }

            return ValidationResult.Success;
        }
    }
}
