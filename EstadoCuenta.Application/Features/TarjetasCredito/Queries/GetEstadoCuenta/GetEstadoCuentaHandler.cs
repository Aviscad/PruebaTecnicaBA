using EstadoCuenta.Domain.DTOs;
using EstadoCuenta.Domain.Interfaces;
using MediatR;

namespace EstadoCuenta.Application.Features.TarjetasCredito.Queries.GetEstadoCuenta
{
    public class GetEstadoCuentaHandler : IRequestHandler<GetEstadoCuentaQuery, EstadoCuentaDto>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetEstadoCuentaHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<EstadoCuentaDto> Handle(GetEstadoCuentaQuery request, CancellationToken cancellationToken)
        {
            var estadoCuenta = await _unitOfWork.TarjetaCredito.GetEstadoCuentaAsync(request.TarjetaCreditoId, cancellationToken);

            return estadoCuenta;
        }
    }
}
