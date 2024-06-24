using EstadoCuenta.Domain.DTOs;
using MediatR;

namespace EstadoCuenta.Application.Features.Compras.Command
{
    public class CreateCompraCommand : IRequest<ComprasDto>
    {
        public int TarjetaCreditoId { get; set; }
        private int NumeroAutorizacion { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public decimal Monto { get; set; }
    }
}
