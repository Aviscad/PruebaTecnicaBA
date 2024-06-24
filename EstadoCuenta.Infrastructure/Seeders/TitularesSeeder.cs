using EstadoCuenta.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstadoCuenta.Infrastructure.Seeders
{
    public static class TitularesSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Titular>().HasData(
                new Titular { Id = 1, Nombre = "Juan Carlos", Apellidos = "Pérez Gómez" },
                new Titular { Id = 2, Nombre = "María José", Apellidos = "García López" },
                new Titular { Id = 3, Nombre = "Roberto Carlos", Apellidos = "Martínez Sánchez" },
                new Titular { Id = 4, Nombre = "Ana María", Apellidos = "Rodríguez Díaz" },
                new Titular { Id = 5, Nombre = "Carlos Alberto", Apellidos = "López Fernández" },
                new Titular { Id = 6, Nombre = "Laura Patricia", Apellidos = "Fernández González" },
                new Titular { Id = 7, Nombre = "Jorge Luis", Apellidos = "Sánchez Romero" },
                new Titular { Id = 8, Nombre = "Sofía Elena", Apellidos = "Ramírez Torres" },
                new Titular { Id = 9, Nombre = "Diego Armando", Apellidos = "Gómez Navarro" },
                new Titular { Id = 10, Nombre = "Valeria Sofía", Apellidos = "Díaz Herrera" },
                new Titular { Id = 11, Nombre = "Eduardo Antonio", Apellidos = "Vargas Cruz" },
                new Titular { Id = 12, Nombre = "Paola Andrea", Apellidos = "Castro Morales" },
                new Titular { Id = 13, Nombre = "Alejandro Manuel", Apellidos = "Morales García" },
                new Titular { Id = 14, Nombre = "Adriana Beatriz", Apellidos = "Herrera Jiménez" },
                new Titular { Id = 15, Nombre = "Guillermo Javier", Apellidos = "Núñez Flores" }
            );
        }
    }
}
