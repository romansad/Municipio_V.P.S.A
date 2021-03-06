﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistance;

namespace Persistance.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200418144415_DbInicial")]
    partial class DbInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Denuncia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Calle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EntreCalles1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EntreCalles2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EstadoDenunciaId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("IpDenunciante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Legajo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<int>("TipoDenunciaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EstadoDenunciaId");

                    b.HasIndex("TipoDenunciaId");

                    b.ToTable("Denuncias");
                });

            modelBuilder.Entity("Domain.EstadoDenuncia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EstadoDenuncias");
                });

            modelBuilder.Entity("Domain.TipoDenuncia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TiempoMaxTratamiento")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("TipoDenuncias");
                });

            modelBuilder.Entity("Domain.Denuncia", b =>
                {
                    b.HasOne("Domain.EstadoDenuncia", "EstadoDenuncia")
                        .WithMany()
                        .HasForeignKey("EstadoDenunciaId");

                    b.HasOne("Domain.TipoDenuncia", "TipoDenuncia")
                        .WithMany()
                        .HasForeignKey("TipoDenunciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
