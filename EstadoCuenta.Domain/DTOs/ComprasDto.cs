namespace EstadoCuenta.Domain.DTOs
{
    public class ComprasDto
    {
        public int NumeroAutorizacion { get; set; }
        public DateOnly Fecha { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public decimal Monto { get; set; }
    }
}
