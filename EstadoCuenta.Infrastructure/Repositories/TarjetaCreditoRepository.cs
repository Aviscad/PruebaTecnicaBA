using AutoMapper;
using EstadoCuenta.Domain.DTOs;
using EstadoCuenta.Domain.Entities;
using EstadoCuenta.Domain.Exceptions;
using EstadoCuenta.Domain.Interfaces;
using EstadoCuenta.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;


namespace EstadoCuenta.Infrastructure.Repositories
{
    public class TarjetaCreditoRepository : GenericRepository<TarjetaCredito>, ITarjetaCreditoRespository
    {
        private readonly DateTime mesActual;
        private readonly DateTime mesAnterior;
        private readonly DateTime mesSiguiente;
        public TarjetaCreditoRepository(ApplicationDbContext context, IMapper _mapper)
            : base(context, _mapper)
        {
            mesActual = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            mesAnterior = mesActual.AddMonths(-1);
            mesSiguiente = mesActual.AddMonths(1);
        }

        public override async Task<IEnumerable<TarjetaCredito>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await _context.TarjetasCredito
                .Include(t => t.Titular)
                .ToListAsync(cancellationToken);
        }

        public override async Task<TarjetaCredito?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return await _context.TarjetasCredito
                .Include(t => t.Titular)
                .FirstOrDefaultAsync(t => t.Id == id, cancellationToken);
        }

        public async Task<EstadoCuentaDto> GetEstadoCuentaAsync(int tarjetaCreditoId, CancellationToken cancellationToken)
        {
            var tarjeta = await _context.TarjetasCredito
                .Where(tc => tc.Id == tarjetaCreditoId)
                .FirstOrDefaultAsync(cancellationToken);

            if (tarjeta is null) throw new NotFoundException("No se encontró la tarjeta de crédito.");

            var titular = _context.Titulares.Where(t => t.Id == tarjeta.TitularId).FirstOrDefault();

            var compras = _context.Compras
                .Where(c =>
                    c.TarjetaCreditoId == tarjetaCreditoId &&
                    c.Fecha >= mesActual &&
                    c.Fecha < mesSiguiente
                )
                .OrderByDescending(tc => tc.Fecha)
                .ToList();

            var TotalMesActual = compras.Sum(c => c.Monto);
            var TotalMesAnterior = _context.Compras
                .Where(c =>
                    c.TarjetaCreditoId == tarjetaCreditoId &&
                    c.Fecha >= mesAnterior &&
                    c.Fecha < mesActual
                )
                .Sum(c => c.Monto);

            decimal interesBonificable = tarjeta.SaldoActual * tarjeta.PorcentajeInteres;
            decimal cuotaMinimaPagar = tarjeta.SaldoActual * tarjeta.PorcentajeSaldoMinimo;
            decimal totalPagar = tarjeta.SaldoActual;
            decimal totalContadoInteres = totalPagar + interesBonificable;

            var estadoCuenta = new EstadoCuentaDto
            {
                NombreCliente = $"{titular.Nombre} {titular.Apellidos}",
                NumeroTarjeta = tarjeta.NumeroTarjeta,
                SaldoActual = tarjeta.SaldoActual,
                LimiteCredito = tarjeta.LimiteCredito,
                SaldoDisponible = tarjeta.SaldoDisponible,
                TotalMesActual = TotalMesActual,
                TotalMesAnterior = TotalMesAnterior,
                InteresBonificable = interesBonificable,
                CoutaMinimaAPagar = cuotaMinimaPagar,
                MontoTotal = totalPagar,
                MontoTotalConInteres = totalContadoInteres,
                Compras = _mapper.Map<List<ComprasDto>>(compras)
            };

            return estadoCuenta;
        }

        public async Task<List<TransaccionesDto>> GetTransacciones(int tarjetaCreditoId, CancellationToken cancellationToken)
        {
            var transacciones = await _context.Transacciones
                .Where(t => 
                    t.TarjetaCreditoId == tarjetaCreditoId &&
                    t.Fecha >= mesActual &&
                    t.Fecha < mesSiguiente
                 )
                .OrderByDescending( t => t.Fecha )  
                .ToListAsync(cancellationToken);

            if (!transacciones.Any()) throw new NotFoundException($"No se encontraron transacciones para el ID {tarjetaCreditoId}");

            return _mapper.Map<List<TransaccionesDto>>(transacciones);
        }
    }
}
