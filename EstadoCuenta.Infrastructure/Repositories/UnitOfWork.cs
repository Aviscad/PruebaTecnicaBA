using AutoMapper;
using EstadoCuenta.Domain.Interfaces;
using EstadoCuenta.Infrastructure.Data;

namespace EstadoCuenta.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public UnitOfWork(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            Compra = new CompraRepository(_context, _mapper);
            Pago = new PagoRepository(_context, _mapper);
            TarjetaCredito = new TarjetaCreditoRepository(_context, _mapper);
            Titular = new TitularRepository(_context, _mapper);
            Transaccion = new TransaccionRepository(_context, _mapper);
        }

        public ICompraRespository Compra { get; }

        public IPagoRespository Pago { get; }

        public ITarjetaCreditoRespository TarjetaCredito { get; }

        public ITitularRepository Titular { get; }

        public ITransaccionRespository Transaccion { get; }

        public void Dispose()
        {
            _context.Dispose();
        }

        public int save()
        {
            return _context.SaveChanges();
        }

        public async Task saveAsync(CancellationToken cancellationToken = default)
        {
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
