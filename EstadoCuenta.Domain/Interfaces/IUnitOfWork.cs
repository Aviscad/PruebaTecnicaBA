using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstadoCuenta.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICompraRespository Compra { get; }
        IPagoRespository Pago { get; }
        ITarjetaCreditoRespository TarjetaCredito { get; }
        ITitularRepository Titular { get; }
        ITransaccionRespository Transaccion { get; }
        int save();
        Task saveAsync(CancellationToken cancellation = default);
    }
}
