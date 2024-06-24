using AutoMapper;
using EstadoCuenta.Domain.DTOs;
using EstadoCuenta.Domain.Interfaces;
using MediatR;

namespace EstadoCuenta.Application.Features.TarjetasCredito.Queries.GetAll
{
    public class GetAllTarjetaCreditoQueryHandler : IRequestHandler<GetAllTarjetasCreditoQuery, IEnumerable<TarjetaCreditoDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllTarjetaCreditoQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TarjetaCreditoDto>> Handle(GetAllTarjetasCreditoQuery request, CancellationToken cancellationToken)
        {
            var tarjetas = await _unitOfWork.TarjetaCredito.GetAllAsync(cancellationToken);
            return _mapper.Map<IEnumerable<TarjetaCreditoDto>>(tarjetas);
        }
    }
}
