using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstadoCuenta.Domain.Entities
{
    public class TarjetaCredito
    {
        public int Id { get; set; }
        public int TitularId { get; set; }
        public string NumeroTarjeta { get; set; }
        public decimal SaldoActual { get; set; }
        public decimal LimiteCredito { get; set; }
        public decimal SaldoDisponible { get; set; }
        public decimal PorcentajeInteres { get; set; }
        public decimal PorcentajeSaldoMinimo { get; set; }

        public List<Compra> Compras { get; set; }
        public List<Pago> Pagos { get; set; }
        public Titular Titular { get; set; }
    }
}
