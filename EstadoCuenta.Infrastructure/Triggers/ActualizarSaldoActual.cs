using EstadoCuenta.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstadoCuenta.Infrastructure.Triggers
{
    public static class ActualizarSaldoActual
    {
        public static async Task Update(DbContext context)
        {
            var pagos = context.ChangeTracker.Entries<Pago>()
                .Where(e => e.State == EntityState.Added)
                .Select(e => e.Entity);

            foreach (var pago in pagos)
            {
                var tarjetaCredito = await context.Set<TarjetaCredito>().FindAsync(pago.TarjetaCreditoId);
                if (tarjetaCredito != null)
                {
                    tarjetaCredito.SaldoActual -= pago.Monto;
                    tarjetaCredito.SaldoDisponible += pago.Monto;
                }
            }

            var compras = context.ChangeTracker.Entries<Compra>()
                .Where(e => e.State == EntityState.Added)
                .Select(e => e.Entity);

            foreach (var compra in compras)
            {
                var tarjetaCredito = await context.Set<TarjetaCredito>().FindAsync(compra.TarjetaCreditoId);
                if (tarjetaCredito != null)
                {
                    tarjetaCredito.SaldoActual += compra.Monto;
                    tarjetaCredito.SaldoDisponible -= compra.Monto;
                }
            }
        }
    }
}