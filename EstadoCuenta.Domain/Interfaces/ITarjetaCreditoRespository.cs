using EstadoCuenta.Domain.DTOs;
using EstadoCuenta.Domain.Entities;

namespace EstadoCuenta.Domain.Interfaces
{
    public interface ITarjetaCreditoRespository : IGenericRepository<TarjetaCredito>
    {
        Task<EstadoCuentaDto> GetEstadoCuentaAsync(int tarjetaCreditoId, CancellationToken cancellationToken);
        Task<List<TransaccionesDto>> GetTransacciones(int tarjetaCreditoId, CancellationToken cancellationToken);
    }
}
