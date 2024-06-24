using EstadoCuenta.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EstadoCuenta.Infrastructure.Seeders
{
    public static class TransaccionesSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transaccion>().HasData(
                new Transaccion { Id = 1, NumeroAutorizacion = 111111, TarjetaCreditoId = 1, Fecha = new DateTime(2024, 6, 1), Descripcion = "Pago de TC", Monto = 50m, TipoTransaccionId = 2 },
                new Transaccion { Id = 2, NumeroAutorizacion = 111112, TarjetaCreditoId = 1, Fecha = new DateTime(2024, 6, 15), Descripcion = "Pago de TC", Monto = 100m, TipoTransaccionId = 2 },

                new Transaccion { Id = 3, NumeroAutorizacion = 111113, TarjetaCreditoId = 2, Fecha = new DateTime(2024, 6, 2), Descripcion = "Pago de TC", Monto = 60m, TipoTransaccionId = 2 },
                new Transaccion { Id = 4, NumeroAutorizacion = 111114, TarjetaCreditoId = 2, Fecha = new DateTime(2024, 6, 16), Descripcion = "Pago de TC", Monto = 110m, TipoTransaccionId = 2 },

                new Transaccion { Id = 5, NumeroAutorizacion = 111115, TarjetaCreditoId = 3, Fecha = new DateTime(2024, 6, 3), Descripcion = "Pago de TC", Monto = 70m, TipoTransaccionId = 2 },
                new Transaccion { Id = 6, NumeroAutorizacion = 111116, TarjetaCreditoId = 3, Fecha = new DateTime(2024, 6, 17), Descripcion = "Pago de TC", Monto = 120m, TipoTransaccionId = 2 },

                new Transaccion { Id = 7, NumeroAutorizacion = 111117, TarjetaCreditoId = 4, Fecha = new DateTime(2024, 6, 4), Descripcion = "Pago de TC", Monto = 80m, TipoTransaccionId = 2 },
                new Transaccion { Id = 8, NumeroAutorizacion = 111118, TarjetaCreditoId = 4, Fecha = new DateTime(2024, 6, 18), Descripcion = "Pago de TC", Monto = 130m, TipoTransaccionId = 2 },

                new Transaccion { Id = 9, NumeroAutorizacion = 111119, TarjetaCreditoId = 5, Fecha = new DateTime(2024, 6, 5), Descripcion = "Pago de TC", Monto = 90m, TipoTransaccionId = 2 },
                new Transaccion { Id = 10, NumeroAutorizacion = 111120, TarjetaCreditoId = 5, Fecha = new DateTime(2024, 6, 19), Descripcion = "Pago de TC", Monto = 140m, TipoTransaccionId = 2 },

                new Transaccion { Id = 11, NumeroAutorizacion = 111121, TarjetaCreditoId = 6, Fecha = new DateTime(2024, 6, 6), Descripcion = "Pago de TC", Monto = 100m, TipoTransaccionId = 2 },
                new Transaccion { Id = 12, NumeroAutorizacion = 111122, TarjetaCreditoId = 6, Fecha = new DateTime(2024, 6, 20), Descripcion = "Pago de TC", Monto = 150m, TipoTransaccionId = 2 },

                new Transaccion { Id = 13, NumeroAutorizacion = 111123, TarjetaCreditoId = 7, Fecha = new DateTime(2024, 6, 7), Descripcion = "Pago de TC", Monto = 110m, TipoTransaccionId = 2 },
                new Transaccion { Id = 14, NumeroAutorizacion = 111124, TarjetaCreditoId = 7, Fecha = new DateTime(2024, 6, 21), Descripcion = "Pago de TC", Monto = 160m, TipoTransaccionId = 2 },

                new Transaccion { Id = 15, NumeroAutorizacion = 111125, TarjetaCreditoId = 8, Fecha = new DateTime(2024, 6, 8), Descripcion = "Pago de TC", Monto = 120m, TipoTransaccionId = 2 },
                new Transaccion { Id = 16, NumeroAutorizacion = 111126, TarjetaCreditoId = 8, Fecha = new DateTime(2024, 6, 22), Descripcion = "Pago de TC", Monto = 170m, TipoTransaccionId = 2 },

                new Transaccion { Id = 17, NumeroAutorizacion = 111127, TarjetaCreditoId = 9, Fecha = new DateTime(2024, 6, 9), Descripcion = "Pago de TC", Monto = 130m, TipoTransaccionId = 2 },
                new Transaccion { Id = 18, NumeroAutorizacion = 111128, TarjetaCreditoId = 9, Fecha = new DateTime(2024, 6, 23), Descripcion = "Pago de TC", Monto = 180m, TipoTransaccionId = 2 },

                new Transaccion { Id = 19, NumeroAutorizacion = 111129, TarjetaCreditoId = 10, Fecha = new DateTime(2024, 6, 10), Descripcion = "Pago de TC", Monto = 140m, TipoTransaccionId = 2 },
                new Transaccion { Id = 20, NumeroAutorizacion = 111130, TarjetaCreditoId = 10, Fecha = new DateTime(2024, 6, 24), Descripcion = "Pago de TC", Monto = 190m, TipoTransaccionId = 2 },

                new Transaccion { Id = 21, NumeroAutorizacion = 111131, TarjetaCreditoId = 11, Fecha = new DateTime(2024, 6, 11), Descripcion = "Pago de TC", Monto = 150m, TipoTransaccionId = 2 },
                new Transaccion { Id = 22, NumeroAutorizacion = 111132, TarjetaCreditoId = 11, Fecha = new DateTime(2024, 6, 25), Descripcion = "Pago de TC", Monto = 200m, TipoTransaccionId = 2 },

                new Transaccion { Id = 23, NumeroAutorizacion = 111133, TarjetaCreditoId = 12, Fecha = new DateTime(2024, 6, 12), Descripcion = "Pago de TC", Monto = 160m, TipoTransaccionId = 2 },
                new Transaccion { Id = 24, NumeroAutorizacion = 111134, TarjetaCreditoId = 12, Fecha = new DateTime(2024, 6, 26), Descripcion = "Pago de TC", Monto = 210m, TipoTransaccionId = 2 },

                new Transaccion { Id = 25, NumeroAutorizacion = 111135, TarjetaCreditoId = 13, Fecha = new DateTime(2024, 6, 13), Descripcion = "Pago de TC", Monto = 170m, TipoTransaccionId = 2 },
                new Transaccion { Id = 26, NumeroAutorizacion = 111136, TarjetaCreditoId = 13, Fecha = new DateTime(2024, 6, 27), Descripcion = "Pago de TC", Monto = 220m, TipoTransaccionId = 2 },

                new Transaccion { Id = 27, NumeroAutorizacion = 111137, TarjetaCreditoId = 14, Fecha = new DateTime(2024, 6, 14), Descripcion = "Pago de TC", Monto = 180m, TipoTransaccionId = 2 },
                new Transaccion { Id = 28, NumeroAutorizacion = 111138, TarjetaCreditoId = 14, Fecha = new DateTime(2024, 6, 28), Descripcion = "Pago de TC", Monto = 230m, TipoTransaccionId = 2 },

                new Transaccion { Id = 29, NumeroAutorizacion = 111139, TarjetaCreditoId = 15, Fecha = new DateTime(2024, 6, 15), Descripcion = "Pago de TC", Monto = 190m, TipoTransaccionId = 2 },
                new Transaccion { Id = 30, NumeroAutorizacion = 111140, TarjetaCreditoId = 15, Fecha = new DateTime(2024, 6, 29), Descripcion = "Pago de TC", Monto = 240m, TipoTransaccionId = 2 },


                new Transaccion { Id = 31, TipoTransaccionId = 1, NumeroAutorizacion = 123456, TarjetaCreditoId = 1, Fecha = new DateTime(2024, 6, 10), Descripcion = "Compra en tienda A", Monto = 100m },
                new Transaccion { Id = 32, TipoTransaccionId = 1, NumeroAutorizacion = 123457, TarjetaCreditoId = 1, Fecha = new DateTime(2024, 6, 10), Descripcion = "Compra en tienda B", Monto = 150m },
                new Transaccion { Id = 33, TipoTransaccionId = 1, NumeroAutorizacion = 123458, TarjetaCreditoId = 1, Fecha = new DateTime(2024, 6, 10), Descripcion = "Compra en tienda C", Monto = 200m },
                new Transaccion { Id = 34, TipoTransaccionId = 1, NumeroAutorizacion = 123459, TarjetaCreditoId = 1, Fecha = new DateTime(2024, 6, 10), Descripcion = "Compra en tienda D", Monto = 250m },
                new Transaccion { Id = 35, TipoTransaccionId = 1, NumeroAutorizacion = 123460, TarjetaCreditoId = 1, Fecha = new DateTime(2024, 5, 10), Descripcion = "Compra en tienda E", Monto = 300m },

                new Transaccion { Id = 36, TipoTransaccionId = 1, NumeroAutorizacion = 123461, TarjetaCreditoId = 2, Fecha = new DateTime(2024, 6, 12), Descripcion = "Compra en tienda F", Monto = 110m },
                new Transaccion { Id = 37, TipoTransaccionId = 1, NumeroAutorizacion = 123462, TarjetaCreditoId = 2, Fecha = new DateTime(2024, 6, 12), Descripcion = "Compra en tienda G", Monto = 120m },
                new Transaccion { Id = 38, TipoTransaccionId = 1, NumeroAutorizacion = 123463, TarjetaCreditoId = 2, Fecha = new DateTime(2024, 6, 12), Descripcion = "Compra en tienda H", Monto = 130m },
                new Transaccion { Id = 39, TipoTransaccionId = 1, NumeroAutorizacion = 123464, TarjetaCreditoId = 2, Fecha = new DateTime(2024, 6, 12), Descripcion = "Compra en tienda I", Monto = 140m },
                new Transaccion { Id = 40, TipoTransaccionId = 1, NumeroAutorizacion = 123465, TarjetaCreditoId = 2, Fecha = new DateTime(2024, 5, 12), Descripcion = "Compra en tienda J", Monto = 150m },

                new Transaccion { Id = 41, TipoTransaccionId = 1, NumeroAutorizacion = 123466, TarjetaCreditoId = 3, Fecha = new DateTime(2024, 6, 14), Descripcion = "Compra en tienda K", Monto = 160m },
                new Transaccion { Id = 42, TipoTransaccionId = 1, NumeroAutorizacion = 123467, TarjetaCreditoId = 3, Fecha = new DateTime(2024, 6, 14), Descripcion = "Compra en tienda L", Monto = 170m },
                new Transaccion { Id = 43, TipoTransaccionId = 1, NumeroAutorizacion = 123468, TarjetaCreditoId = 3, Fecha = new DateTime(2024, 6, 14), Descripcion = "Compra en tienda M", Monto = 180m },
                new Transaccion { Id = 44, TipoTransaccionId = 1, NumeroAutorizacion = 123469, TarjetaCreditoId = 3, Fecha = new DateTime(2024, 6, 14), Descripcion = "Compra en tienda N", Monto = 190m },
                new Transaccion { Id = 45, TipoTransaccionId = 1, NumeroAutorizacion = 123470, TarjetaCreditoId = 3, Fecha = new DateTime(2024, 5, 14), Descripcion = "Compra en tienda O", Monto = 200m },

                new Transaccion { Id = 46, TipoTransaccionId = 1, NumeroAutorizacion = 123471, TarjetaCreditoId = 4, Fecha = new DateTime(2024, 6, 16), Descripcion = "Compra en tienda P", Monto = 210m },
                new Transaccion { Id = 47, TipoTransaccionId = 1, NumeroAutorizacion = 123472, TarjetaCreditoId = 4, Fecha = new DateTime(2024, 6, 16), Descripcion = "Compra en tienda Q", Monto = 220m },
                new Transaccion { Id = 48, TipoTransaccionId = 1, NumeroAutorizacion = 123473, TarjetaCreditoId = 4, Fecha = new DateTime(2024, 6, 16), Descripcion = "Compra en tienda R", Monto = 230m },
                new Transaccion { Id = 49, TipoTransaccionId = 1, NumeroAutorizacion = 123474, TarjetaCreditoId = 4, Fecha = new DateTime(2024, 6, 16), Descripcion = "Compra en tienda S", Monto = 240m },
                new Transaccion { Id = 50, TipoTransaccionId = 1, NumeroAutorizacion = 123475, TarjetaCreditoId = 4, Fecha = new DateTime(2024, 5, 16), Descripcion = "Compra en tienda T", Monto = 250m },

                new Transaccion { Id = 51, TipoTransaccionId = 1, NumeroAutorizacion = 123476, TarjetaCreditoId = 5, Fecha = new DateTime(2024, 6, 18), Descripcion = "Compra en tienda U", Monto = 260m },
                new Transaccion { Id = 52, TipoTransaccionId = 1, NumeroAutorizacion = 123477, TarjetaCreditoId = 5, Fecha = new DateTime(2024, 6, 18), Descripcion = "Compra en tienda V", Monto = 270m },
                new Transaccion { Id = 53, TipoTransaccionId = 1, NumeroAutorizacion = 123478, TarjetaCreditoId = 5, Fecha = new DateTime(2024, 6, 18), Descripcion = "Compra en tienda W", Monto = 280m },
                new Transaccion { Id = 54, TipoTransaccionId = 1, NumeroAutorizacion = 123479, TarjetaCreditoId = 5, Fecha = new DateTime(2024, 6, 18), Descripcion = "Compra en tienda X", Monto = 290m },
                new Transaccion { Id = 55, TipoTransaccionId = 1, NumeroAutorizacion = 123480, TarjetaCreditoId = 5, Fecha = new DateTime(2024, 5, 18), Descripcion = "Compra en tienda Y", Monto = 300m },

                new Transaccion { Id = 56, TipoTransaccionId = 1, NumeroAutorizacion = 123481, TarjetaCreditoId = 6, Fecha = new DateTime(2024, 6, 20), Descripcion = "Compra en tienda Z", Monto = 310m },
                new Transaccion { Id = 57, TipoTransaccionId = 1, NumeroAutorizacion = 123482, TarjetaCreditoId = 6, Fecha = new DateTime(2024, 6, 20), Descripcion = "Compra en tienda AA", Monto = 320m },
                new Transaccion { Id = 58, TipoTransaccionId = 1, NumeroAutorizacion = 123483, TarjetaCreditoId = 6, Fecha = new DateTime(2024, 6, 20), Descripcion = "Compra en tienda BB", Monto = 330m },
                new Transaccion { Id = 59, TipoTransaccionId = 1, NumeroAutorizacion = 123484, TarjetaCreditoId = 6, Fecha = new DateTime(2024, 6, 20), Descripcion = "Compra en tienda CC", Monto = 340m },
                new Transaccion { Id = 60, TipoTransaccionId = 1, NumeroAutorizacion = 123485, TarjetaCreditoId = 6, Fecha = new DateTime(2024, 5, 20), Descripcion = "Compra en tienda DD", Monto = 350m },

                new Transaccion { Id = 61, TipoTransaccionId = 1, NumeroAutorizacion = 123486, TarjetaCreditoId = 7, Fecha = new DateTime(2024, 6, 22), Descripcion = "Compra en tienda EE", Monto = 360m },
                new Transaccion { Id = 62, TipoTransaccionId = 1, NumeroAutorizacion = 123487, TarjetaCreditoId = 7, Fecha = new DateTime(2024, 6, 22), Descripcion = "Compra en tienda FF", Monto = 370m },
                new Transaccion { Id = 63, TipoTransaccionId = 1, NumeroAutorizacion = 123488, TarjetaCreditoId = 7, Fecha = new DateTime(2024, 6, 22), Descripcion = "Compra en tienda GG", Monto = 380m },
                new Transaccion { Id = 64, TipoTransaccionId = 1, NumeroAutorizacion = 123489, TarjetaCreditoId = 7, Fecha = new DateTime(2024, 6, 22), Descripcion = "Compra en tienda HH", Monto = 390m },
                new Transaccion { Id = 65, TipoTransaccionId = 1, NumeroAutorizacion = 123490, TarjetaCreditoId = 7, Fecha = new DateTime(2024, 5, 22), Descripcion = "Compra en tienda II", Monto = 400m },

                new Transaccion { Id = 66, TipoTransaccionId = 1, NumeroAutorizacion = 123491, TarjetaCreditoId = 8, Fecha = new DateTime(2024, 6, 24), Descripcion = "Compra en tienda JJ", Monto = 410m },
                new Transaccion { Id = 67, TipoTransaccionId = 1, NumeroAutorizacion = 123492, TarjetaCreditoId = 8, Fecha = new DateTime(2024, 6, 24), Descripcion = "Compra en tienda KK", Monto = 420m },
                new Transaccion { Id = 68, TipoTransaccionId = 1, NumeroAutorizacion = 123493, TarjetaCreditoId = 8, Fecha = new DateTime(2024, 6, 24), Descripcion = "Compra en tienda LL", Monto = 430m },
                new Transaccion { Id = 69, TipoTransaccionId = 1, NumeroAutorizacion = 123494, TarjetaCreditoId = 8, Fecha = new DateTime(2024, 6, 24), Descripcion = "Compra en tienda MM", Monto = 440m },
                new Transaccion { Id = 70, TipoTransaccionId = 1, NumeroAutorizacion = 123495, TarjetaCreditoId = 8, Fecha = new DateTime(2024, 5, 24), Descripcion = "Compra en tienda NN", Monto = 450m },

                new Transaccion { Id = 71, TipoTransaccionId = 1, NumeroAutorizacion = 123496, TarjetaCreditoId = 9, Fecha = new DateTime(2024, 6, 26), Descripcion = "Compra en tienda OO", Monto = 460m },
                new Transaccion { Id = 72, TipoTransaccionId = 1, NumeroAutorizacion = 123497, TarjetaCreditoId = 9, Fecha = new DateTime(2024, 6, 26), Descripcion = "Compra en tienda PP", Monto = 470m },
                new Transaccion { Id = 73, TipoTransaccionId = 1, NumeroAutorizacion = 123498, TarjetaCreditoId = 9, Fecha = new DateTime(2024, 6, 26), Descripcion = "Compra en tienda QQ", Monto = 480m },
                new Transaccion { Id = 74, TipoTransaccionId = 1, NumeroAutorizacion = 123499, TarjetaCreditoId = 9, Fecha = new DateTime(2024, 6, 26), Descripcion = "Compra en tienda RR", Monto = 490m },
                new Transaccion { Id = 75, TipoTransaccionId = 1, NumeroAutorizacion = 123500, TarjetaCreditoId = 9, Fecha = new DateTime(2024, 5, 26), Descripcion = "Compra en tienda SS", Monto = 500m },

                new Transaccion { Id = 76, TipoTransaccionId = 1, NumeroAutorizacion = 123501, TarjetaCreditoId = 10, Fecha = new DateTime(2024, 6, 28), Descripcion = "Compra en tienda TT", Monto = 510m },
                new Transaccion { Id = 77, TipoTransaccionId = 1, NumeroAutorizacion = 123502, TarjetaCreditoId = 10, Fecha = new DateTime(2024, 6, 28), Descripcion = "Compra en tienda UU", Monto = 520m },
                new Transaccion { Id = 78, TipoTransaccionId = 1, NumeroAutorizacion = 123503, TarjetaCreditoId = 10, Fecha = new DateTime(2024, 6, 28), Descripcion = "Compra en tienda VV", Monto = 530m },
                new Transaccion { Id = 79, TipoTransaccionId = 1, NumeroAutorizacion = 123504, TarjetaCreditoId = 10, Fecha = new DateTime(2024, 6, 28), Descripcion = "Compra en tienda WW", Monto = 540m },
                new Transaccion { Id = 80, TipoTransaccionId = 1, NumeroAutorizacion = 123505, TarjetaCreditoId = 10, Fecha = new DateTime(2024, 5, 28), Descripcion = "Compra en tienda XX", Monto = 550m },

                new Transaccion { Id = 81, TipoTransaccionId = 1, NumeroAutorizacion = 123506, TarjetaCreditoId = 11, Fecha = new DateTime(2024, 6, 30), Descripcion = "Compra en tienda YY", Monto = 560m },
                new Transaccion { Id = 82, TipoTransaccionId = 1, NumeroAutorizacion = 123507, TarjetaCreditoId = 11, Fecha = new DateTime(2024, 6, 29), Descripcion = "Compra en tienda ZZ", Monto = 570m },
                new Transaccion { Id = 83, TipoTransaccionId = 1, NumeroAutorizacion = 123508, TarjetaCreditoId = 11, Fecha = new DateTime(2024, 6, 30), Descripcion = "Compra en tienda AAA", Monto = 580m },
                new Transaccion { Id = 84, TipoTransaccionId = 1, NumeroAutorizacion = 123509, TarjetaCreditoId = 11, Fecha = new DateTime(2024, 6, 30), Descripcion = "Compra en tienda BBB", Monto = 590m },
                new Transaccion { Id = 85, TipoTransaccionId = 1, NumeroAutorizacion = 123510, TarjetaCreditoId = 11, Fecha = new DateTime(2024, 5, 30), Descripcion = "Compra en tienda CCC", Monto = 600m },

                new Transaccion { Id = 86, TipoTransaccionId = 1, NumeroAutorizacion = 123511, TarjetaCreditoId = 12, Fecha = new DateTime(2024, 5, 31), Descripcion = "Compra en tienda DDD", Monto = 610m },
                new Transaccion { Id = 87, TipoTransaccionId = 1, NumeroAutorizacion = 123512, TarjetaCreditoId = 12, Fecha = new DateTime(2024, 6, 29), Descripcion = "Compra en tienda EEE", Monto = 620m },
                new Transaccion { Id = 88, TipoTransaccionId = 1, NumeroAutorizacion = 123513, TarjetaCreditoId = 12, Fecha = new DateTime(2024, 5, 31), Descripcion = "Compra en tienda FFF", Monto = 630m },
                new Transaccion { Id = 89, TipoTransaccionId = 1, NumeroAutorizacion = 123514, TarjetaCreditoId = 12, Fecha = new DateTime(2024, 6, 30), Descripcion = "Compra en tienda GGG", Monto = 640m },
                new Transaccion { Id = 90, TipoTransaccionId = 1, NumeroAutorizacion = 123515, TarjetaCreditoId = 12, Fecha = new DateTime(2024, 5, 31), Descripcion = "Compra en tienda HHH", Monto = 650m },

                new Transaccion { Id = 91, TipoTransaccionId = 1, NumeroAutorizacion = 123516, TarjetaCreditoId = 13, Fecha = new DateTime(2024, 5, 31), Descripcion = "Compra en tienda III", Monto = 660m },
                new Transaccion { Id = 92, TipoTransaccionId = 1, NumeroAutorizacion = 123517, TarjetaCreditoId = 13, Fecha = new DateTime(2024, 6, 29), Descripcion = "Compra en tienda JJJ", Monto = 670m },
                new Transaccion { Id = 93, TipoTransaccionId = 1, NumeroAutorizacion = 123518, TarjetaCreditoId = 13, Fecha = new DateTime(2024, 5, 31), Descripcion = "Compra en tienda KKK", Monto = 680m },
                new Transaccion { Id = 94, TipoTransaccionId = 1, NumeroAutorizacion = 123519, TarjetaCreditoId = 13, Fecha = new DateTime(2024, 6, 30), Descripcion = "Compra en tienda LLL", Monto = 690m },
                new Transaccion { Id = 95, TipoTransaccionId = 1, NumeroAutorizacion = 123520, TarjetaCreditoId = 13, Fecha = new DateTime(2024, 5, 31), Descripcion = "Compra en tienda MMM", Monto = 700m }
            );

        }
    }
}
 