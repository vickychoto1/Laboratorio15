using System.ComponentModel.DataAnnotations;

namespace Laboratorio12.Models
{
    public class Producto
    {
        [Required]
        [StringLength(10,
           ErrorMessage = "Código muy largo (máximo 5 letras)")]
        [Display(Name = "Código del Producto")]
        public string Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        [Range(0.01, 999999.99, ErrorMessage = "El precio debe ser mayor que cero")]
        public decimal? Precio { get; set; }
        [Required]
        [Range(0.01, 999999.99, ErrorMessage = "El precio debe ser mayor que cero")]
        public decimal? PrecioVenta { get; set; }

        
    }
}
