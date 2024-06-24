namespace EstadoCuenta.Domain.DTOs
{
    public class TarjetaCreditoDto
    {
        public int TarjetaId { get; set; }
        public string NumeroTarjeta { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
    }
}
