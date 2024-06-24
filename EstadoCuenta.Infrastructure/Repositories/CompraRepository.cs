using AutoMapper;
using EstadoCuenta.Domain.Entities;
using EstadoCuenta.Domain.Interfaces;
using EstadoCuenta.Infrastructure.Data;

namespace EstadoCuenta.Infrastructure.Repositories
{
    public class CompraRepository : GenericRepository<Compra>, ICompraRespository
    {
        public CompraRepository(ApplicationDbContext context, IMapper _mapper)
            : base(context, _mapper)
        {
        }

        public override async Task<Compra> AddAsync(Compra entity, CancellationToken cancellationToken = default)
        {
            await base.AddAsync(entity, cancellationToken);

            var transaccion = new Transaccion
            {
                TarjetaCreditoId = entity.TarjetaCreditoId,
                NumeroAutorizacion = entity.NumeroAutorizacion,
                Fecha = entity.Fecha,
                Descripcion = entity.Descripcion,
                Monto = entity.Monto,
                TipoTransaccionId = 1
            };

            await _context.Transacciones.AddAsync(transaccion, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            return entity;
        }
    }
}
