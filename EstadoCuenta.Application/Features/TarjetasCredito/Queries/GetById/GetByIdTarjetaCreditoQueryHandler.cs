using AutoMapper;
using EstadoCuenta.Domain.DTOs;
using EstadoCuenta.Domain.Exceptions;
using EstadoCuenta.Domain.Interfaces;
using MediatR;

namespace EstadoCuenta.Application.Features.TarjetasCredito.Queries.GetById
{
    public class GetByIdTarjetaCreditoQueryHandler : IRequestHandler<GetByIdTarjetaCreditoQuery, TarjetaCreditoDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetByIdTarjetaCreditoQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<TarjetaCreditoDto> Handle(GetByIdTarjetaCreditoQuery request, CancellationToken cancellationToken)
        {
            var tarjeta = await _unitOfWork.TarjetaCredito.GetByIdAsync(request.Id, cancellationToken);
            if (tarjeta is null) throw new NotFoundException($"Tarjeta de crédito con ID {request.Id} no encontrada.");

            return _mapper.Map<TarjetaCreditoDto>(tarjeta);
        }
    }
}
