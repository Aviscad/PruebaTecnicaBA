using EstadoCuenta.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EstadoCuenta.Infrastructure.Seeders
{
    public static class ComprasSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Compra>().HasData(
                new Compra { Id = 1, NumeroAutorizacion = 123456, TarjetaCreditoId = 1, Fecha = new DateTime(2024, 6, 10), Descripcion = "Compra en tienda A", Monto = 100m },
                new Compra { Id = 2, NumeroAutorizacion = 123457, TarjetaCreditoId = 1, Fecha = new DateTime(2024, 6, 10), Descripcion = "Compra en tienda B", Monto = 150m },
                new Compra { Id = 3, NumeroAutorizacion = 123458, TarjetaCreditoId = 1, Fecha = new DateTime(2024, 6, 10), Descripcion = "Compra en tienda C", Monto = 200m },
                new Compra { Id = 4, NumeroAutorizacion = 123459, TarjetaCreditoId = 1, Fecha = new DateTime(2024, 6, 10), Descripcion = "Compra en tienda D", Monto = 250m },
                new Compra { Id = 5, NumeroAutorizacion = 123460, TarjetaCreditoId = 1, Fecha = new DateTime(2024, 5, 10), Descripcion = "Compra en tienda E", Monto = 300m },

                new Compra { Id = 6, NumeroAutorizacion = 123461, TarjetaCreditoId = 2, Fecha = new DateTime(2024, 6, 12), Descripcion = "Compra en tienda F", Monto = 110m },
                new Compra { Id = 7, NumeroAutorizacion = 123462, TarjetaCreditoId = 2, Fecha = new DateTime(2024, 6, 12), Descripcion = "Compra en tienda G", Monto = 120m },
                new Compra { Id = 8, NumeroAutorizacion = 123463, TarjetaCreditoId = 2, Fecha = new DateTime(2024, 6, 12), Descripcion = "Compra en tienda H", Monto = 130m },
                new Compra { Id = 9, NumeroAutorizacion = 123464, TarjetaCreditoId = 2, Fecha = new DateTime(2024, 6, 12), Descripcion = "Compra en tienda I", Monto = 140m },
                new Compra { Id = 10, NumeroAutorizacion = 123465, TarjetaCreditoId = 2, Fecha = new DateTime(2024, 5, 12), Descripcion = "Compra en tienda J", Monto = 150m },

                new Compra { Id = 11, NumeroAutorizacion = 123466, TarjetaCreditoId = 3, Fecha = new DateTime(2024, 6, 14), Descripcion = "Compra en tienda K", Monto = 160m },
                new Compra { Id = 12, NumeroAutorizacion = 123467, TarjetaCreditoId = 3, Fecha = new DateTime(2024, 6, 14), Descripcion = "Compra en tienda L", Monto = 170m },
                new Compra { Id = 13, NumeroAutorizacion = 123468, TarjetaCreditoId = 3, Fecha = new DateTime(2024, 6, 14), Descripcion = "Compra en tienda M", Monto = 180m },
                new Compra { Id = 14, NumeroAutorizacion = 123469, TarjetaCreditoId = 3, Fecha = new DateTime(2024, 6, 14), Descripcion = "Compra en tienda N", Monto = 190m },
                new Compra { Id = 15, NumeroAutorizacion = 123470, TarjetaCreditoId = 3, Fecha = new DateTime(2024, 5, 14), Descripcion = "Compra en tienda O", Monto = 200m },

                new Compra { Id = 16, NumeroAutorizacion = 123471, TarjetaCreditoId = 4, Fecha = new DateTime(2024, 6, 16), Descripcion = "Compra en tienda P", Monto = 210m },
                new Compra { Id = 17, NumeroAutorizacion = 123472, TarjetaCreditoId = 4, Fecha = new DateTime(2024, 6, 16), Descripcion = "Compra en tienda Q", Monto = 220m },
                new Compra { Id = 18, NumeroAutorizacion = 123473, TarjetaCreditoId = 4, Fecha = new DateTime(2024, 6, 16), Descripcion = "Compra en tienda R", Monto = 230m },
                new Compra { Id = 19, NumeroAutorizacion = 123474, TarjetaCreditoId = 4, Fecha = new DateTime(2024, 6, 16), Descripcion = "Compra en tienda S", Monto = 240m },
                new Compra { Id = 20, NumeroAutorizacion = 123475, TarjetaCreditoId = 4, Fecha = new DateTime(2024, 5, 16), Descripcion = "Compra en tienda T", Monto = 250m },

                new Compra { Id = 21, NumeroAutorizacion = 123476, TarjetaCreditoId = 5, Fecha = new DateTime(2024, 6, 18), Descripcion = "Compra en tienda U", Monto = 260m },
                new Compra { Id = 22, NumeroAutorizacion = 123477, TarjetaCreditoId = 5, Fecha = new DateTime(2024, 6, 18), Descripcion = "Compra en tienda V", Monto = 270m },
                new Compra { Id = 23, NumeroAutorizacion = 123478, TarjetaCreditoId = 5, Fecha = new DateTime(2024, 6, 18), Descripcion = "Compra en tienda W", Monto = 280m },
                new Compra { Id = 24, NumeroAutorizacion = 123479, TarjetaCreditoId = 5, Fecha = new DateTime(2024, 6, 18), Descripcion = "Compra en tienda X", Monto = 290m },
                new Compra { Id = 25, NumeroAutorizacion = 123480, TarjetaCreditoId = 5, Fecha = new DateTime(2024, 5, 18), Descripcion = "Compra en tienda Y", Monto = 300m },

                new Compra { Id = 26, NumeroAutorizacion = 123481, TarjetaCreditoId = 6, Fecha = new DateTime(2024, 6, 20), Descripcion = "Compra en tienda Z", Monto = 310m },
                new Compra { Id = 27, NumeroAutorizacion = 123482, TarjetaCreditoId = 6, Fecha = new DateTime(2024, 6, 20), Descripcion = "Compra en tienda AA", Monto = 320m },
                new Compra { Id = 28, NumeroAutorizacion = 123483, TarjetaCreditoId = 6, Fecha = new DateTime(2024, 6, 20), Descripcion = "Compra en tienda BB", Monto = 330m },
                new Compra { Id = 29, NumeroAutorizacion = 123484, TarjetaCreditoId = 6, Fecha = new DateTime(2024, 6, 20), Descripcion = "Compra en tienda CC", Monto = 340m },
                new Compra { Id = 30, NumeroAutorizacion = 123485, TarjetaCreditoId = 6, Fecha = new DateTime(2024, 5, 20), Descripcion = "Compra en tienda DD", Monto = 350m },

                new Compra { Id = 31, NumeroAutorizacion = 123486, TarjetaCreditoId = 7, Fecha = new DateTime(2024, 6, 22), Descripcion = "Compra en tienda EE", Monto = 360m },
                new Compra { Id = 32, NumeroAutorizacion = 123487, TarjetaCreditoId = 7, Fecha = new DateTime(2024, 6, 22), Descripcion = "Compra en tienda FF", Monto = 370m },
                new Compra { Id = 33, NumeroAutorizacion = 123488, TarjetaCreditoId = 7, Fecha = new DateTime(2024, 6, 22), Descripcion = "Compra en tienda GG", Monto = 380m },
                new Compra { Id = 34, NumeroAutorizacion = 123489, TarjetaCreditoId = 7, Fecha = new DateTime(2024, 6, 22), Descripcion = "Compra en tienda HH", Monto = 390m },
                new Compra { Id = 35, NumeroAutorizacion = 123490, TarjetaCreditoId = 7, Fecha = new DateTime(2024, 5, 22), Descripcion = "Compra en tienda II", Monto = 400m },

                new Compra { Id = 36, NumeroAutorizacion = 123491, TarjetaCreditoId = 8, Fecha = new DateTime(2024, 6, 24), Descripcion = "Compra en tienda JJ", Monto = 410m },
                new Compra { Id = 37, NumeroAutorizacion = 123492, TarjetaCreditoId = 8, Fecha = new DateTime(2024, 6, 24), Descripcion = "Compra en tienda KK", Monto = 420m },
                new Compra { Id = 38, NumeroAutorizacion = 123493, TarjetaCreditoId = 8, Fecha = new DateTime(2024, 6, 24), Descripcion = "Compra en tienda LL", Monto = 430m },
                new Compra { Id = 39, NumeroAutorizacion = 123494, TarjetaCreditoId = 8, Fecha = new DateTime(2024, 6, 24), Descripcion = "Compra en tienda MM", Monto = 440m },
                new Compra { Id = 40, NumeroAutorizacion = 123495, TarjetaCreditoId = 8, Fecha = new DateTime(2024, 5, 24), Descripcion = "Compra en tienda NN", Monto = 450m },

                new Compra { Id = 41, NumeroAutorizacion = 123496, TarjetaCreditoId = 9, Fecha = new DateTime(2024, 6, 26), Descripcion = "Compra en tienda OO", Monto = 460m },
                new Compra { Id = 42, NumeroAutorizacion = 123497, TarjetaCreditoId = 9, Fecha = new DateTime(2024, 6, 26), Descripcion = "Compra en tienda PP", Monto = 470m },
                new Compra { Id = 43, NumeroAutorizacion = 123498, TarjetaCreditoId = 9, Fecha = new DateTime(2024, 6, 26), Descripcion = "Compra en tienda QQ", Monto = 480m },
                new Compra { Id = 44, NumeroAutorizacion = 123499, TarjetaCreditoId = 9, Fecha = new DateTime(2024, 6, 26), Descripcion = "Compra en tienda RR", Monto = 490m },
                new Compra { Id = 45, NumeroAutorizacion = 123500, TarjetaCreditoId = 9, Fecha = new DateTime(2024, 5, 26), Descripcion = "Compra en tienda SS", Monto = 500m },

                new Compra { Id = 46, NumeroAutorizacion = 123501, TarjetaCreditoId = 10, Fecha = new DateTime(2024, 6, 28), Descripcion = "Compra en tienda TT", Monto = 510m },
                new Compra { Id = 47, NumeroAutorizacion = 123502, TarjetaCreditoId = 10, Fecha = new DateTime(2024, 6, 28), Descripcion = "Compra en tienda UU", Monto = 520m },
                new Compra { Id = 48, NumeroAutorizacion = 123503, TarjetaCreditoId = 10, Fecha = new DateTime(2024, 6, 28), Descripcion = "Compra en tienda VV", Monto = 530m },
                new Compra { Id = 49, NumeroAutorizacion = 123504, TarjetaCreditoId = 10, Fecha = new DateTime(2024, 6, 28), Descripcion = "Compra en tienda WW", Monto = 540m },
                new Compra { Id = 50, NumeroAutorizacion = 123505, TarjetaCreditoId = 10, Fecha = new DateTime(2024, 5, 28), Descripcion = "Compra en tienda XX", Monto = 550m },

                new Compra { Id = 51, NumeroAutorizacion = 123506, TarjetaCreditoId = 11, Fecha = new DateTime(2024, 6, 30), Descripcion = "Compra en tienda YY", Monto = 560m },
                new Compra { Id = 52, NumeroAutorizacion = 123507, TarjetaCreditoId = 11, Fecha = new DateTime(2024, 6, 29), Descripcion = "Compra en tienda ZZ", Monto = 570m },
                new Compra { Id = 53, NumeroAutorizacion = 123508, TarjetaCreditoId = 11, Fecha = new DateTime(2024, 6, 30), Descripcion = "Compra en tienda AAA", Monto = 580m },
                new Compra { Id = 54, NumeroAutorizacion = 123509, TarjetaCreditoId = 11, Fecha = new DateTime(2024, 6, 30), Descripcion = "Compra en tienda BBB", Monto = 590m },
                new Compra { Id = 55, NumeroAutorizacion = 123510, TarjetaCreditoId = 11, Fecha = new DateTime(2024, 5, 30), Descripcion = "Compra en tienda CCC", Monto = 600m },

                new Compra { Id = 56, NumeroAutorizacion = 123511, TarjetaCreditoId = 12, Fecha = new DateTime(2024, 6, 1), Descripcion = "Compra en tienda DDD", Monto = 610m },
                new Compra { Id = 57, NumeroAutorizacion = 123512, TarjetaCreditoId = 12, Fecha = new DateTime(2024, 6, 1), Descripcion = "Compra en tienda EEE", Monto = 620m },
                new Compra { Id = 58, NumeroAutorizacion = 123513, TarjetaCreditoId = 12, Fecha = new DateTime(2024, 6, 1), Descripcion = "Compra en tienda FFF", Monto = 630m },
                new Compra { Id = 59, NumeroAutorizacion = 123514, TarjetaCreditoId = 12, Fecha = new DateTime(2024, 5, 1), Descripcion = "Compra en tienda GGG", Monto = 640m },

                new Compra { Id = 60, NumeroAutorizacion = 123515, TarjetaCreditoId = 13, Fecha = new DateTime(2024, 6, 2), Descripcion = "Compra en tienda HHH", Monto = 650m },
                new Compra { Id = 61, NumeroAutorizacion = 123516, TarjetaCreditoId = 13, Fecha = new DateTime(2024, 6, 2), Descripcion = "Compra en tienda III", Monto = 660m },
                new Compra { Id = 62, NumeroAutorizacion = 123517, TarjetaCreditoId = 13, Fecha = new DateTime(2024, 6, 2), Descripcion = "Compra en tienda JJJ", Monto = 670m },

                new Compra { Id = 63, NumeroAutorizacion = 123518, TarjetaCreditoId = 14, Fecha = new DateTime(2024, 6, 3), Descripcion = "Compra en tienda KKK", Monto = 680m },
                new Compra { Id = 64, NumeroAutorizacion = 123519, TarjetaCreditoId = 14, Fecha = new DateTime(2024, 5, 3), Descripcion = "Compra en tienda LLL", Monto = 690m },

                new Compra { Id = 65, NumeroAutorizacion = 123520, TarjetaCreditoId = 15, Fecha = new DateTime(2024, 6, 4), Descripcion = "Compra en tienda MMM", Monto = 700m }
                );
        }
    }
}