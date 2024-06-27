using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AmazonApp.Entities;

public partial class AmazonDBContext : DbContext
{
    public AmazonDBContext()
    {
    }

    public AmazonDBContext(DbContextOptions<AmazonDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-FP28SOE;Initial Catalog=AmazonDB;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__User__1788CC4C45DA349A");

            entity.ToTable("User");

            entity.HasIndex(e => e.Email, "UQ__User__A9D105346E0037C2").IsUnique();

            entity.HasIndex(e => e.UserName, "UQ__User__C9F284564CF83D45").IsUnique();

            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
