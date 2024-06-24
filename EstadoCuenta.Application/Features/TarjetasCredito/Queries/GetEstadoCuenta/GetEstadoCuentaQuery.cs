using EstadoCuenta.Domain.DTOs;
using MediatR;

namespace EstadoCuenta.Application.Features.TarjetasCredito.Queries.GetEstadoCuenta
{
    public class GetEstadoCuentaQuery : IRequest<EstadoCuentaDto>
    {
        public int TarjetaCreditoId { get; set; }
    }
}
