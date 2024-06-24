using EstadoCuenta.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using EstadoCuenta.Infrastructure.Triggers;
using EstadoCuenta.Infrastructure.Extensions;

namespace EstadoCuenta.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Titular> Titulares { get; set; }
        public DbSet<TarjetaCredito> TarjetasCredito { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<Transaccion> Transacciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Titular>()
            .HasMany(t => t.TarjetasCredito)
            .WithOne(tc => tc.Titular)
            .HasForeignKey(tc => tc.TitularId);

            //Seeders
            modelBuilder.SeedTitulares();
            modelBuilder.SeedTipoTransacciones(); 
            modelBuilder.SeedTarjetasCredito();
            modelBuilder.SeedCompras();
            modelBuilder.SeedPagos();
            modelBuilder.SeedTransacciones();

            base.OnModelCreating(modelBuilder);
        }

        public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            await ActualizarSaldoActual.Update(this);

            return await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

    }
}
