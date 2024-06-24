namespace EstadoCuenta.Domain.DTOs
{ 
    public class PagosDto
    {
        public int TarjetaCreditoId { get; set; }
        public int NumeroAutorizacion { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; } = "Pagos TC";
        public decimal Monto { get; set; }
    }
}
