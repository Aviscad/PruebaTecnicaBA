using AutoMapper;
using EstadoCuenta.Domain.DTOs;
using EstadoCuenta.Domain.Entities;


namespace EstadoCuenta.Application.Common.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TarjetaCredito, TarjetaCreditoDto>()
                .ForMember(dest => dest.TarjetaId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.NumeroTarjeta, opt => opt.MapFrom(src => src.NumeroTarjeta))
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Titular.Nombre))
                .ForMember(dest => dest.Apellidos, opt => opt.MapFrom(src => src.Titular.Apellidos));

            CreateMap<Compra, ComprasDto>()
                .ForMember(dest => dest.Fecha, opt => opt.MapFrom(src => DateOnly.FromDateTime(src.Fecha)));

            CreateMap<List<Compra>, List<ComprasDto>>()
                .ConvertUsing((source, destination, context) =>
                {
                    var comprasDtoList = source.Select(c => context.Mapper.Map<ComprasDto>(c)).ToList();
                    return comprasDtoList;
                });

            CreateMap<Transaccion, TransaccionesDto>()
                .ForMember(dest => dest.Fecha, opt => opt.MapFrom(src => DateOnly.FromDateTime(src.Fecha)))
                .ForMember(dest => dest.Cargo, opt => opt.MapFrom(src => src.TipoTransaccionId == 1 ? src.Monto : 0))
                .ForMember(dest => dest.Abono, opt => opt.MapFrom(src => src.TipoTransaccionId != 1 ? src.Monto : 0));

            CreateMap<Pago, PagosDto>().ReverseMap();
        }
    }
}
