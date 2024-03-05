﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parcial2_AP1_AaronHernandez.API.DAL;

#nullable disable

namespace Parcial2_AP1_AaronHernandez.API.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("Compartido.Models.Accesorios", b =>
                {
                    b.Property<int>("AccesorioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AccesorioId");

                    b.ToTable("Accesorios");
                });

            modelBuilder.Entity("Compartido.Models.VehiculoDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccesorioId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Valor")
                        .HasColumnType("REAL");

                    b.Property<int>("VehiculoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("VehiculoDetalle");
                });

            modelBuilder.Entity("Compartido.Models.Vehiculos", b =>
                {
                    b.Property<int>("VehiculoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Costo")
                        .HasColumnType("REAL");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<float>("Gasto")
                        .HasColumnType("REAL");

                    b.HasKey("VehiculoId");

                    b.ToTable("Vehiculos");
                });
#pragma warning restore 612, 618
        }
    }
}
