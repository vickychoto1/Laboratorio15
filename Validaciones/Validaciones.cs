using System;
using System.ComponentModel.DataAnnotations;

namespace Laboratorio12.Validations
{
    public class FechaMayorAHoyAttribute : ValidationAttribute
    {
        public FechaMayorAHoyAttribute()
        {
            ErrorMessage = "La fecha de vencimiento debe ser mayor a la fecha actual.";
        }

        //override sobrescribe  el método IsValid de la clase ValidationAttribute que ya incluye C#.
        //value es el valor que vamos a recibir para validar
        public override bool IsValid(object value)
        {
            // si el valor es nulo, no se valida
            if (value == null) return true; // el [Required] con el que validamos ya se encarga de esto

            // si el valor es de tipo DateTime
            if (value is DateTime fecha)
            {
                return fecha.Date > DateTime.Today; //comprueba si la fecha es mayor a la fecha actual, returna true si es mayor
            }

            return false;
        }
    }
}
