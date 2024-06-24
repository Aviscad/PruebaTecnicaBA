using AutoMapper;
using EstadoCuenta.Domain.DTOs;
using EstadoCuenta.Application.Services;
using EstadoCuenta.Domain.Entities;
using EstadoCuenta.Domain.Exceptions;
using EstadoCuenta.Domain.Interfaces;
using MediatR;

namespace EstadoCuenta.Application.Features.Compras.Command
{
    public class CreateCompraCommandHandler : IRequestHandler<CreateCompraCommand, ComprasDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateCompraCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ComprasDto> Handle(CreateCompraCommand request, CancellationToken cancellationToken)
        {
            var infoTarjeta = await _unitOfWork.TarjetaCredito.GetByIdAsync(request.TarjetaCreditoId);

            if (infoTarjeta is null) throw new NotFoundException("No se encontro una tarjeta asociada");

            var nuevoSaldo = infoTarjeta.SaldoActual + request.Monto;

            if (nuevoSaldo > infoTarjeta.LimiteCredito) throw new CreditLimitExceededException("Se ha alcanzado el límite de crédito");

            var compra = new Compra()
            {
                NumeroAutorizacion = NumeroAutorizacionService.Create(),
                TarjetaCreditoId = request.TarjetaCreditoId,
                Descripcion = request.Descripcion,
                Fecha = request.Fecha,
                Monto = request.Monto,
            };

            await _unitOfWork.Compra.AddAsync(compra, cancellationToken);

            return _mapper.Map<ComprasDto>(compra);
        }
    }
}
