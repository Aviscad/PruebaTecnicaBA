using EstadoCuenta.Domain.DTOs;
using MediatR;

namespace EstadoCuenta.Application.Features.TarjetasCredito.Queries.GetTransacciones
{
    public class GetTransaccionsQuery : IRequest<List<TransaccionesDto>>
    {
        public int TarjetaCreditoId { get; set; }
    }

}
