using AutoMapper;
using EstadoCuenta.Domain.DTOs;
using EstadoCuenta.Application.Services;
using EstadoCuenta.Domain.Entities;
using EstadoCuenta.Domain.Interfaces;
using MediatR;

namespace EstadoCuenta.Application.Features.Pagos.Commands
{
    public class CreatePagoCommandHandler : IRequestHandler<CreatePagoCommand, PagosDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CreatePagoCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<PagosDto> Handle(CreatePagoCommand request, CancellationToken cancellationToken)
        {
            var pago = new Pago()
            {
                NumeroAutorizacion = NumeroAutorizacionService.Create(),
                TarjetaCreditoId = request.TarjetaCreditoId,
                Fecha = request.Fecha,
                Monto = request.Monto,
            };

            await _unitOfWork.Pago.AddAsync(pago, cancellationToken);

            return _mapper.Map<PagosDto>(pago);
        }
    }
}
