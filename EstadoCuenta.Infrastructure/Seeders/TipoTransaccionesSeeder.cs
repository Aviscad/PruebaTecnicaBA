using EstadoCuenta.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EstadoCuenta.Infrastructure.Seeders
{
    public static class TipoTransaccionesSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TipoTransaccion>().HasData(
                new TipoTransaccion { Id = 1, Tipo = "Compra" },
                new TipoTransaccion { Id = 2, Tipo = "Pago" }
            );
        }
    }
}
