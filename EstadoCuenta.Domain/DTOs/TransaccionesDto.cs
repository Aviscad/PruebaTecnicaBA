namespace EstadoCuenta.Domain.DTOs
{
    public class TransaccionesDto
    {
        public int NumeroAutorizacion { get; set; }
        public DateOnly Fecha { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public decimal Cargo { get; set; }
        public decimal Abono { get; set; }
    }
}
