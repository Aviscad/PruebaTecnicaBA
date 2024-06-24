using System.ComponentModel.DataAnnotations;

namespace FrontendRazor.Models
{
    public class ComprasModel
    {
        [Required]
        public int TarjetaCreditoId { get; set; }
        public int NumeroAutorizacion { get; set; }
        public DateTime Fecha { get; set; }
        [Required]
        public string Descripcion { get; set; } = string.Empty;
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "El Monto debe ser mayor que cero.")]
        public decimal Monto { get; set; }
    }
}
