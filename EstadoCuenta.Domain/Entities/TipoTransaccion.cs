namespace EstadoCuenta.Domain.Entities
{
    public class TipoTransaccion
    {
        public int Id { get; set; }
        public string Tipo { get; set; } = string.Empty;

        public List<Transaccion> Transaccion { get; set; }
    }
}
