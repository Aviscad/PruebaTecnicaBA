﻿// <auto-generated />
using System;
using EstadoCuenta.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EstadoCuenta.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240621221213_Seeder TipoTransacciones")]
    partial class SeederTipoTransacciones
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EstadoCuenta.Domain.Entities.Compra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Monto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TarjetaCreditoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TarjetaCreditoId");

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("EstadoCuenta.Domain.Entities.Pago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Monto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TarjetaCreditoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TarjetaCreditoId");

                    b.ToTable("Pagos");
                });

            modelBuilder.Entity("EstadoCuenta.Domain.Entities.TarjetaCredito", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("LimiteCredito")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("NumeroTarjeta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PorcentajeInteres")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PorcentajeSaldoMinimo")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SaldoActual")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SaldoDisponible")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TitularId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TitularId");

                    b.ToTable("TarjetasCredito");
                });

            modelBuilder.Entity("EstadoCuenta.Domain.Entities.TipoTransaccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipoTransaccion");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Tipo = "Compra"
                        },
                        new
                        {
                            Id = 2,
                            Tipo = "Pago"
                        });
                });

            modelBuilder.Entity("EstadoCuenta.Domain.Entities.Titular", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Titulares");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Apellidos = "Pérez",
                            Nombre = "Juan"
                        },
                        new
                        {
                            Id = 2,
                            Apellidos = "García",
                            Nombre = "María"
                        },
                        new
                        {
                            Id = 3,
                            Apellidos = "Martínez",
                            Nombre = "Roberto"
                        },
                        new
                        {
                            Id = 4,
                            Apellidos = "Rodríguez",
                            Nombre = "Ana"
                        },
                        new
                        {
                            Id = 5,
                            Apellidos = "López",
                            Nombre = "Carlos"
                        },
                        new
                        {
                            Id = 6,
                            Apellidos = "Fernández",
                            Nombre = "Laura"
                        },
                        new
                        {
                            Id = 7,
                            Apellidos = "Sánchez",
                            Nombre = "Jorge"
                        },
                        new
                        {
                            Id = 8,
                            Apellidos = "Ramírez",
                            Nombre = "Sofía"
                        },
                        new
                        {
                            Id = 9,
                            Apellidos = "Gómez",
                            Nombre = "Diego"
                        },
                        new
                        {
                            Id = 10,
                            Apellidos = "Díaz",
                            Nombre = "Valeria"
                        },
                        new
                        {
                            Id = 11,
                            Apellidos = "Vargas",
                            Nombre = "Eduardo"
                        },
                        new
                        {
                            Id = 12,
                            Apellidos = "Castro",
                            Nombre = "Paola"
                        },
                        new
                        {
                            Id = 13,
                            Apellidos = "Morales",
                            Nombre = "Alejandro"
                        },
                        new
                        {
                            Id = 14,
                            Apellidos = "Herrera",
                            Nombre = "Adriana"
                        },
                        new
                        {
                            Id = 15,
                            Apellidos = "Núñez",
                            Nombre = "Guillermo"
                        });
                });

            modelBuilder.Entity("EstadoCuenta.Domain.Entities.Transaccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Monto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TarjetaCreditoId")
                        .HasColumnType("int");

                    b.Property<int>("TipoTransaccionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TarjetaCreditoId");

                    b.HasIndex("TipoTransaccionId");

                    b.ToTable("Transacciones");
                });

            modelBuilder.Entity("EstadoCuenta.Domain.Entities.Compra", b =>
                {
                    b.HasOne("EstadoCuenta.Domain.Entities.TarjetaCredito", "TarjetaCredito")
                        .WithMany("Compras")
                        .HasForeignKey("TarjetaCreditoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TarjetaCredito");
                });

            modelBuilder.Entity("EstadoCuenta.Domain.Entities.Pago", b =>
                {
                    b.HasOne("EstadoCuenta.Domain.Entities.TarjetaCredito", "TarjetaCredito")
                        .WithMany("Pagos")
                        .HasForeignKey("TarjetaCreditoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TarjetaCredito");
                });

            modelBuilder.Entity("EstadoCuenta.Domain.Entities.TarjetaCredito", b =>
                {
                    b.HasOne("EstadoCuenta.Domain.Entities.Titular", "Titular")
                        .WithMany("TarjetasCredito")
                        .HasForeignKey("TitularId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Titular");
                });

            modelBuilder.Entity("EstadoCuenta.Domain.Entities.Transaccion", b =>
                {
                    b.HasOne("EstadoCuenta.Domain.Entities.TarjetaCredito", "TarjetaCredito")
                        .WithMany()
                        .HasForeignKey("TarjetaCreditoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EstadoCuenta.Domain.Entities.TipoTransaccion", "TipoTransaccion")
                        .WithMany("Transaccion")
                        .HasForeignKey("TipoTransaccionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TarjetaCredito");

                    b.Navigation("TipoTransaccion");
                });

            modelBuilder.Entity("EstadoCuenta.Domain.Entities.TarjetaCredito", b =>
                {
                    b.Navigation("Compras");

                    b.Navigation("Pagos");
                });

            modelBuilder.Entity("EstadoCuenta.Domain.Entities.TipoTransaccion", b =>
                {
                    b.Navigation("Transaccion");
                });

            modelBuilder.Entity("EstadoCuenta.Domain.Entities.Titular", b =>
                {
                    b.Navigation("TarjetasCredito");
                });
#pragma warning restore 612, 618
        }
    }
}
