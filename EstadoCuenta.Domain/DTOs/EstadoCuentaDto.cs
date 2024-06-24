namespace EstadoCuenta.Domain.DTOs
{
    public class EstadoCuentaDto
    {
        public string NombreCliente { get; set; } = string.Empty;
        public string NumeroTarjeta { get; set; } = string.Empty;
        public decimal SaldoActual { get; set; }
        public decimal LimiteCredito { get; set; }
        public decimal SaldoDisponible { get; set; }
        public decimal TotalMesActual { get; set; }
        public decimal TotalMesAnterior { get; set; }
        public decimal InteresBonificable { get; set; }
        public decimal CoutaMinimaAPagar { get; set; }
        public decimal MontoTotal { get; set; } 
        public decimal MontoTotalConInteres { get; set; } 
        public List<ComprasDto> Compras { get; set; } = new List<ComprasDto>();
    }
}
