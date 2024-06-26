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
    [Migration("20240621162031_InitialMigration")]
    partial class InitialMigration
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

                    b.Property<decimal>("PorcentajeConfigurableSaldoMinimo")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PorcentajeInteresConfigurable")
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

                    b.Property<string>("TipoTransaccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TarjetaCreditoId");

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

                    b.Navigation("TarjetaCredito");
                });

            modelBuilder.Entity("EstadoCuenta.Domain.Entities.TarjetaCredito", b =>
                {
                    b.Navigation("Compras");

                    b.Navigation("Pagos");
                });

            modelBuilder.Entity("EstadoCuenta.Domain.Entities.Titular", b =>
                {
                    b.Navigation("TarjetasCredito");
                });
#pragma warning restore 612, 618
        }
    }
}
