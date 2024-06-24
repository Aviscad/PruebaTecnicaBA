using System.ComponentModel.DataAnnotations;

namespace FrontendRazor.Models
{
    public class PagosModel
    {
        public int NumeroAutorizacion { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "El Monto debe ser mayor que cero.")]
        public decimal Monto { get; set; }
    }
}
