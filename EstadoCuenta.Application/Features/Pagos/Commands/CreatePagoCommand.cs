using EstadoCuenta.Domain.DTOs;
using MediatR;

namespace EstadoCuenta.Application.Features.Pagos.Commands
{
    public class CreatePagoCommand : IRequest<PagosDto>
    {
        public int TarjetaCreditoId { get; set; }
        private int NumeroAutorizacion { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
    }
}
