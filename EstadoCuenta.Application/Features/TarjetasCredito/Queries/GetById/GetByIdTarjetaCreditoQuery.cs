using EstadoCuenta.Domain.DTOs;
using MediatR;

namespace EstadoCuenta.Application.Features.TarjetasCredito.Queries.GetById
{
    public class GetByIdTarjetaCreditoQuery : IRequest<TarjetaCreditoDto>
    {
        public int Id { get; set; }
    }
}
