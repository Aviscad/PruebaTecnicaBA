using EstadoCuenta.Infrastructure.Seeders;
using Microsoft.EntityFrameworkCore;

namespace EstadoCuenta.Infrastructure.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void SeedTitulares(this ModelBuilder modelBuilder)
        {
            TitularesSeeder.Seed(modelBuilder);
        }

        public static void SeedTipoTransacciones(this ModelBuilder modelBuilder)
        {
            TipoTransaccionesSeeder.Seed(modelBuilder);
        }

        public static void SeedTarjetasCredito(this ModelBuilder modelBuilder)
        {
            TarjetasCreditoSeeder.Seed(modelBuilder);
        }

        public static void SeedCompras(this ModelBuilder modelBuilder)
        {
            ComprasSeeder.Seed(modelBuilder);
        }

        public static void SeedPagos(this ModelBuilder modelBuilder)
        {
            PagosSeeder.Seed(modelBuilder);
        }

        public static void SeedTransacciones(this ModelBuilder modelBuilder)
        {
            TransaccionesSeeder.Seed(modelBuilder);
        }


    }
}
