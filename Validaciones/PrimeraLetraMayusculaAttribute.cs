using System.ComponentModel.DataAnnotations;

namespace Presupuesto.Validaciones
{
    public class PrimeraLetraMayusculaAttribute:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null || String.IsNullOrEmpty(value.ToString()))
            {
                return ValidationResult.Success;
            }
            var primera = value.ToString()[0].ToString();
            if(primera!=primera.ToUpper())
            {
                return new ValidationResult("La primera letra tiene que ser mayuscula");

            }
            return ValidationResult.Success;
        }
    }
}
