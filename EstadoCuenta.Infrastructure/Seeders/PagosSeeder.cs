using EstadoCuenta.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstadoCuenta.Infrastructure.Seeders
{
    public static class PagosSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pago>().HasData(
                new Pago { Id = 1, NumeroAutorizacion = 111111, TarjetaCreditoId = 1, Fecha = new DateTime(2024, 6, 1), Monto = 50m },
                new Pago { Id = 2, NumeroAutorizacion = 111112, TarjetaCreditoId = 1, Fecha = new DateTime(2024, 6, 15), Monto = 100m },

                new Pago { Id = 3, NumeroAutorizacion = 111113, TarjetaCreditoId = 2, Fecha = new DateTime(2024, 6, 2), Monto = 60m },
                new Pago { Id = 4, NumeroAutorizacion = 111114, TarjetaCreditoId = 2, Fecha = new DateTime(2024, 6, 16), Monto = 110m },

                new Pago { Id = 5, NumeroAutorizacion = 111115, TarjetaCreditoId = 3, Fecha = new DateTime(2024, 6, 3), Monto = 70m },
                new Pago { Id = 6, NumeroAutorizacion = 111116, TarjetaCreditoId = 3, Fecha = new DateTime(2024, 6, 17), Monto = 120m },

                new Pago { Id = 7, NumeroAutorizacion = 111117, TarjetaCreditoId = 4, Fecha = new DateTime(2024, 6, 4), Monto = 80m },
                new Pago { Id = 8, NumeroAutorizacion = 111118, TarjetaCreditoId = 4, Fecha = new DateTime(2024, 6, 18), Monto = 130m },

                new Pago { Id = 9, NumeroAutorizacion = 111119, TarjetaCreditoId = 5, Fecha = new DateTime(2024, 6, 5), Monto = 90m },
                new Pago { Id = 10, NumeroAutorizacion = 111120, TarjetaCreditoId = 5, Fecha = new DateTime(2024, 6, 19), Monto = 140m },

                new Pago { Id = 11, NumeroAutorizacion = 111121, TarjetaCreditoId = 6, Fecha = new DateTime(2024, 6, 6), Monto = 100m },
                new Pago { Id = 12, NumeroAutorizacion = 111122, TarjetaCreditoId = 6, Fecha = new DateTime(2024, 6, 20), Monto = 150m },

                new Pago { Id = 13, NumeroAutorizacion = 111123, TarjetaCreditoId = 7, Fecha = new DateTime(2024, 6, 7), Monto = 110m },
                new Pago { Id = 14, NumeroAutorizacion = 111124, TarjetaCreditoId = 7, Fecha = new DateTime(2024, 6, 21), Monto = 160m },

                new Pago { Id = 15, NumeroAutorizacion = 111125, TarjetaCreditoId = 8, Fecha = new DateTime(2024, 6, 8), Monto = 120m },
                new Pago { Id = 16, NumeroAutorizacion = 111126, TarjetaCreditoId = 8, Fecha = new DateTime(2024, 6, 22), Monto = 170m },

                new Pago { Id = 17, NumeroAutorizacion = 111127, TarjetaCreditoId = 9, Fecha = new DateTime(2024, 6, 9), Monto = 130m },
                new Pago { Id = 18, NumeroAutorizacion = 111128, TarjetaCreditoId = 9, Fecha = new DateTime(2024, 6, 23), Monto = 180m },

                new Pago { Id = 19, NumeroAutorizacion = 111129, TarjetaCreditoId = 10, Fecha = new DateTime(2024, 6, 10), Monto = 140m },
                new Pago { Id = 20, NumeroAutorizacion = 111130, TarjetaCreditoId = 10, Fecha = new DateTime(2024, 6, 24), Monto = 190m },

                new Pago { Id = 21, NumeroAutorizacion = 111131, TarjetaCreditoId = 11, Fecha = new DateTime(2024, 6, 11), Monto = 150m },
                new Pago { Id = 22, NumeroAutorizacion = 111132, TarjetaCreditoId = 11, Fecha = new DateTime(2024, 6, 25), Monto = 200m },

                new Pago { Id = 23, NumeroAutorizacion = 111133, TarjetaCreditoId = 12, Fecha = new DateTime(2024, 6, 12), Monto = 160m },
                new Pago { Id = 24, NumeroAutorizacion = 111134, TarjetaCreditoId = 12, Fecha = new DateTime(2024, 6, 26), Monto = 210m },

                new Pago { Id = 25, NumeroAutorizacion = 111135, TarjetaCreditoId = 13, Fecha = new DateTime(2024, 6, 13), Monto = 170m },
                new Pago { Id = 26, NumeroAutorizacion = 111136, TarjetaCreditoId = 13, Fecha = new DateTime(2024, 6, 27), Monto = 220m },

                new Pago { Id = 27, NumeroAutorizacion = 111137, TarjetaCreditoId = 14, Fecha = new DateTime(2024, 6, 14), Monto = 180m },
                new Pago { Id = 28, NumeroAutorizacion = 111138, TarjetaCreditoId = 14, Fecha = new DateTime(2024, 6, 28), Monto = 230m },

                new Pago { Id = 29, NumeroAutorizacion = 111139, TarjetaCreditoId = 15, Fecha = new DateTime(2024, 6, 15), Monto = 190m },
                new Pago { Id = 30, NumeroAutorizacion = 111140, TarjetaCreditoId = 15, Fecha = new DateTime(2024, 6, 29), Monto = 240m }
            );
        }
    }
}
