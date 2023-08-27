using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace shopping_API.Models.EF;

public partial class ShoppingDbContext : DbContext
{
    public ShoppingDbContext()
    {
    }

    public ShoppingDbContext(DbContextOptions<ShoppingDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=shoppingDB;integrated security=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CId).HasName("PK__customer__D830D47786C455C3");

            entity.ToTable("customers");

            entity.Property(e => e.CId)
                .ValueGeneratedNever()
                .HasColumnName("cId");
            entity.Property(e => e.CAddress)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cAddress");
            entity.Property(e => e.CIsActive).HasColumnName("cIsActive");
            entity.Property(e => e.CName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cName");
            entity.Property(e => e.CType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cType");
            entity.Property(e => e.CWalletBalance).HasColumnName("cWalletBalance");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OId).HasName("PK__orders__C2FECB3B2198A60C");

            entity.ToTable("orders");

            entity.Property(e => e.OId)
                .ValueGeneratedNever()
                .HasColumnName("oId");
            entity.Property(e => e.OStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("oStatus");
            entity.Property(e => e.OType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("oType");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.PId).HasName("PK__products__DD36D56201D1D152");

            entity.ToTable("products");

            entity.Property(e => e.PId)
                .ValueGeneratedNever()
                .HasColumnName("pId");
            entity.Property(e => e.PCategory)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("pCategory");
            entity.Property(e => e.PIsInStock).HasColumnName("pIsInStock");
            entity.Property(e => e.PManufacturer)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("pManufacturer");
            entity.Property(e => e.PName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("pName");
            entity.Property(e => e.PPrice).HasColumnName("pPrice");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
