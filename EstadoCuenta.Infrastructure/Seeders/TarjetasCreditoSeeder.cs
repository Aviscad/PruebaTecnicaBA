using EstadoCuenta.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EstadoCuenta.Infrastructure.Seeders
{
    public static class TarjetasCreditoSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TarjetaCredito>().HasData(
                new TarjetaCredito { Id = 1, TitularId = 1, NumeroTarjeta = "1111 **** **** 4444", SaldoActual = 850m, LimiteCredito = 10000m, SaldoDisponible = 9150m, PorcentajeInteres = 0.15m, PorcentajeSaldoMinimo = 0.05m },
                new TarjetaCredito { Id = 2, TitularId = 2, NumeroTarjeta = "2222 **** **** 5555", SaldoActual = 480m, LimiteCredito = 8000m, SaldoDisponible = 7520m, PorcentajeInteres = 0.17m, PorcentajeSaldoMinimo = 0.04m },
                new TarjetaCredito { Id = 3, TitularId = 3, NumeroTarjeta = "3333 **** **** 6666", SaldoActual = 710m, LimiteCredito = 5000m, SaldoDisponible = 4290m, PorcentajeInteres = 0.18m, PorcentajeSaldoMinimo = 0.03m },
                new TarjetaCredito { Id = 4, TitularId = 4, NumeroTarjeta = "4444 **** **** 7777", SaldoActual = 940m, LimiteCredito = 15000m, SaldoDisponible = 14060m, PorcentajeInteres = 0.16m, PorcentajeSaldoMinimo = 0.05m },
                new TarjetaCredito { Id = 5, TitularId = 5, NumeroTarjeta = "5555 **** **** 8888", SaldoActual = 1170m, LimiteCredito = 12000m, SaldoDisponible = 10830m, PorcentajeInteres = 0.14m, PorcentajeSaldoMinimo = 0.06m },
                new TarjetaCredito { Id = 6, TitularId = 6, NumeroTarjeta = "6666 **** **** 9999", SaldoActual = 1400m, LimiteCredito = 6000m, SaldoDisponible = 4600m, PorcentajeInteres = 0.19m, PorcentajeSaldoMinimo = 0.05m },
                new TarjetaCredito { Id = 7, TitularId = 7, NumeroTarjeta = "7777 **** **** 0000", SaldoActual = 1630m, LimiteCredito = 20000m, SaldoDisponible = 18370m, PorcentajeInteres = 0.15m, PorcentajeSaldoMinimo = 0.04m },
                new TarjetaCredito { Id = 8, TitularId = 8, NumeroTarjeta = "8888 **** **** 1111", SaldoActual = 1860m, LimiteCredito = 7000m, SaldoDisponible = 5140m, PorcentajeInteres = 0.13m, PorcentajeSaldoMinimo = 0.06m },
                new TarjetaCredito { Id = 9, TitularId = 9, NumeroTarjeta = "9999 **** **** 2222", SaldoActual = 2090m, LimiteCredito = 14000m, SaldoDisponible = 11910m, PorcentajeInteres = 0.17m, PorcentajeSaldoMinimo = 0.03m },
                new TarjetaCredito { Id = 10, TitularId = 10, NumeroTarjeta = "0000 **** **** 3333", SaldoActual = 2320m, LimiteCredito = 9000m, SaldoDisponible = 6680m, PorcentajeInteres = 0.16m, PorcentajeSaldoMinimo = 0.04m },
                new TarjetaCredito { Id = 11, TitularId = 11, NumeroTarjeta = "1111 **** **** 4444", SaldoActual = 2550m, LimiteCredito = 10000m, SaldoDisponible = 7450m, PorcentajeInteres = 0.18m, PorcentajeSaldoMinimo = 0.05m },
                new TarjetaCredito { Id = 12, TitularId = 12, NumeroTarjeta = "2222 **** **** 5555", SaldoActual = 2130m, LimiteCredito = 7500m, SaldoDisponible = 5370m, PorcentajeInteres = 0.15m, PorcentajeSaldoMinimo = 0.06m },
                new TarjetaCredito { Id = 13, TitularId = 13, NumeroTarjeta = "3333 **** **** 6666", SaldoActual = 1590m, LimiteCredito = 8000m, SaldoDisponible = 6410m, PorcentajeInteres = 0.17m, PorcentajeSaldoMinimo = 0.04m },
                new TarjetaCredito { Id = 14, TitularId = 14, NumeroTarjeta = "4444 **** **** 7777", SaldoActual = 960m, LimiteCredito = 10000m, SaldoDisponible = 9040m, PorcentajeInteres = 0.14m, PorcentajeSaldoMinimo = 0.03m },
                new TarjetaCredito { Id = 15, TitularId = 15, NumeroTarjeta = "5555 **** **** 8888", SaldoActual = 270m, LimiteCredito = 11000m, SaldoDisponible = 10730m, PorcentajeInteres = 0.16m, PorcentajeSaldoMinimo = 0.05m }
            );

        }
    }
}
