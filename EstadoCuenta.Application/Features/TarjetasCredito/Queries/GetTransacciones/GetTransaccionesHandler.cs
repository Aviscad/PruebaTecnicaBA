using EstadoCuenta.Domain.DTOs;
using EstadoCuenta.Domain.Interfaces;
using MediatR;

namespace EstadoCuenta.Application.Features.TarjetasCredito.Queries.GetTransacciones
{
    public class GetTransaccionesHandler : IRequestHandler<GetTransaccionsQuery, List<TransaccionesDto>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetTransaccionesHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<TransaccionesDto>> Handle(GetTransaccionsQuery request, CancellationToken cancellationToken)
        {
            var transacciones = await _unitOfWork.TarjetaCredito.GetTransacciones(request.TarjetaCreditoId, cancellationToken);

            return transacciones;
        }
    }
}
