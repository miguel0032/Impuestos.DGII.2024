using System;
using System.Collections.Generic;
using Impuestos.Models;
using Microsoft.EntityFrameworkCore;

namespace Impuestos.DAL.Data;

public partial class DataContext : DbContext
{
    public DataContext()
    {
    }

    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ComprobantesFiscale> ComprobantesFiscales { get; set; }

    public virtual DbSet<Contribuyente> Contribuyentes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer();

    //Miguel zabala
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ComprobantesFiscale>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Comproba__3213E83FEF07087D");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.Property(e => e.Itbis18)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("itbis18");
            entity.Property(e => e.Monto)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("monto");
            entity.Property(e => e.Ncf)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NCF");
            entity.Property(e => e.RncCedula)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("rncCedula");

            entity.HasOne(d => d.RncCedulaNavigation).WithMany(p => p.ComprobantesFiscales)
                .HasForeignKey(d => d.RncCedula)
                .HasConstraintName("FK__Comproban__rncCe__4BAC3F29");
        });

        modelBuilder.Entity<Contribuyente>(entity =>
        {
            entity.HasKey(e => e.RncCedula).HasName("PK__Contribu__38AA49B3ED6E0A8E");

            entity.Property(e => e.RncCedula)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("rncCedula");
            entity.Property(e => e.Estatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estatus");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipo");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
