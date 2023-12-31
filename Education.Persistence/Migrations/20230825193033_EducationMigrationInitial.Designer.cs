﻿// <auto-generated />
using System;
using Education.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Education.Persistence.Migrations
{
    [DbContext(typeof(EducationDbContext))]
    [Migration("20230825193033_EducationMigrationInitial")]
    partial class EducationMigrationInitial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Education.Domain.Curso", b =>
                {
                    b.Property<Guid>("CursoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaPublicacion")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Precio")
                        .HasPrecision(14, 2)
                        .HasColumnType("decimal(14,2)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CursoId");

                    b.ToTable("Cursos");

                    b.HasData(
                        new
                        {
                            CursoId = new Guid("fbd3f80e-e3e7-4ccd-ae7a-6287447afcce"),
                            Descripcion = "Curso de C# basico",
                            FechaCreacion = new DateTime(2023, 8, 25, 16, 30, 33, 126, DateTimeKind.Local).AddTicks(1752),
                            FechaPublicacion = new DateTime(2025, 8, 25, 16, 30, 33, 126, DateTimeKind.Local).AddTicks(1764),
                            Precio = 56m,
                            Titulo = "C# desde cero hasta avanzado."
                        },
                        new
                        {
                            CursoId = new Guid("6c19970a-6674-455e-b081-69d8d8433f05"),
                            Descripcion = "Curso de Java",
                            FechaCreacion = new DateTime(2023, 8, 25, 16, 30, 33, 126, DateTimeKind.Local).AddTicks(1799),
                            FechaPublicacion = new DateTime(2025, 8, 25, 16, 30, 33, 126, DateTimeKind.Local).AddTicks(1799),
                            Precio = 25m,
                            Titulo = "Master en Java Spring desde las raices"
                        },
                        new
                        {
                            CursoId = new Guid("e81951f9-7a49-411f-ba7b-a3344ba3f443"),
                            Descripcion = "Curso de Unit Test para NET Core",
                            FechaCreacion = new DateTime(2023, 8, 25, 16, 30, 33, 126, DateTimeKind.Local).AddTicks(1806),
                            FechaPublicacion = new DateTime(2025, 8, 25, 16, 30, 33, 126, DateTimeKind.Local).AddTicks(1806),
                            Precio = 1000m,
                            Titulo = "Master en Unit Test con CQRS"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
