using Laboratorio12.Validations; //el archivo de validaciones
using System.ComponentModel.DataAnnotations;

namespace Laboratorio12.Models
{
    public class Alimento : Producto
    {
        [Required]
        [Display(Name = "Fecha de Vencimiento")]
        [FechaMayorAHoy] // Validación personalizada
        public DateTime FechaVencimiento { get; set; }

        [Required]
        [Display(Name = "Unidad de Medida")]
        public string UnidadMedida { get; set; }
        
    }
}
