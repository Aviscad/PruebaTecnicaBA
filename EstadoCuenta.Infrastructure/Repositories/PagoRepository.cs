using AutoMapper;
using EstadoCuenta.Domain.Entities;
using EstadoCuenta.Domain.Exceptions;
using EstadoCuenta.Domain.Interfaces;
using EstadoCuenta.Infrastructure.Data;

namespace EstadoCuenta.Infrastructure.Repositories
{
    public class PagoRepository : GenericRepository<Pago>, IPagoRespository
    {
        public PagoRepository(ApplicationDbContext context, IMapper _mapper) 
            : base(context, _mapper)
        {
        }

        public override async Task<Pago> AddAsync(Pago entity, CancellationToken cancellationToken = default)
        {
            var tarjeta = _context.TarjetasCredito.FirstOrDefault(t => t.Id == entity.TarjetaCreditoId);
            decimal pagoMinimo = tarjeta.SaldoActual * tarjeta.PorcentajeSaldoMinimo;
            var rounded = Math.Round(pagoMinimo, 2);

            if (entity.Monto < pagoMinimo) throw new PagoMinimoException($"El pago mínimo a realizar es {rounded.ToString("C")}");

            await base.AddAsync(entity, cancellationToken);

            var transaccion = new Transaccion
            {
                TarjetaCreditoId = entity.TarjetaCreditoId,
                NumeroAutorizacion = entity.NumeroAutorizacion,
                Fecha = entity.Fecha,
                Descripcion = "Pago de TC",
                Monto = entity.Monto,
                TipoTransaccionId = 2
            };

            await _context.Transacciones.AddAsync(transaccion, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            return entity;

        }
    }
}
