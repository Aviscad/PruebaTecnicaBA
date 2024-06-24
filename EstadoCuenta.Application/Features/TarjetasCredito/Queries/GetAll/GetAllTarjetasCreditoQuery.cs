using EstadoCuenta.Domain.DTOs;
using MediatR;

namespace EstadoCuenta.Application.Features.TarjetasCredito.Queries.GetAll
{
    public class GetAllTarjetasCreditoQuery : IRequest<IEnumerable<TarjetaCreditoDto>>
    {
    }
}
