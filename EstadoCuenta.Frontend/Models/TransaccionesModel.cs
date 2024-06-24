namespace FrontendRazor.Models
{
    public class TransaccionesModel
    {
        public int NumeroAutorizacion { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public decimal Cargo { get; set; }
        public decimal Abono { get; set; }
    }
}
