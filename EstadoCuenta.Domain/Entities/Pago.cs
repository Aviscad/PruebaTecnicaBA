namespace EstadoCuenta.Domain.Entities
{
    public class Pago
    {
        public int Id { get; set; }
        public int NumeroAutorizacion { get; set; }
        public int TarjetaCreditoId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }

        public TarjetaCredito TarjetaCredito { get; set; }
    }
}
