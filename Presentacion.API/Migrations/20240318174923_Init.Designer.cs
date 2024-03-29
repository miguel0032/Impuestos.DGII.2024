﻿// <auto-generated />
using System;
using Impuestos.DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Presentacion.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240318174923_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Impuestos.Models.ComprobantesFiscale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal?>("Itbis18")
                        .HasColumnType("decimal(18, 2)")
                        .HasColumnName("itbis18");

                    b.Property<decimal?>("Monto")
                        .HasColumnType("decimal(18, 2)")
                        .HasColumnName("monto");

                    b.Property<string>("Ncf")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("NCF");

                    b.Property<string>("RncCedula")
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("varchar(11)")
                        .HasColumnName("rncCedula");

                    b.HasKey("Id")
                        .HasName("PK__Comproba__3213E83FEF07087D");

                    b.HasIndex("RncCedula");

                    b.ToTable("ComprobantesFiscales");
                });

            modelBuilder.Entity("Impuestos.Models.Contribuyente", b =>
                {
                    b.Property<string>("RncCedula")
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("varchar(11)")
                        .HasColumnName("rncCedula");

                    b.Property<string>("Estatus")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("estatus");

                    b.Property<string>("Nombre")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("nombre");

                    b.Property<string>("Tipo")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("tipo");

                    b.HasKey("RncCedula")
                        .HasName("PK__Contribu__38AA49B3ED6E0A8E");

                    b.ToTable("Contribuyentes");
                });

            modelBuilder.Entity("Impuestos.Models.ComprobantesFiscale", b =>
                {
                    b.HasOne("Impuestos.Models.Contribuyente", "RncCedulaNavigation")
                        .WithMany("ComprobantesFiscales")
                        .HasForeignKey("RncCedula")
                        .HasConstraintName("FK__Comproban__rncCe__4BAC3F29");

                    b.Navigation("RncCedulaNavigation");
                });

            modelBuilder.Entity("Impuestos.Models.Contribuyente", b =>
                {
                    b.Navigation("ComprobantesFiscales");
                });
#pragma warning restore 612, 618
        }
    }
}
