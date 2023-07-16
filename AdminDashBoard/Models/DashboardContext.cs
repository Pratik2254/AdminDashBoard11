using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdminDashBoard.Models;

public partial class DashboardContext : DbContext
{
    public DashboardContext()
    {
    }

    public DashboardContext(DbContextOptions<DashboardContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Login> Logins { get; set; }

    public virtual DbSet<Shoe> Shoes { get; set; }

    public virtual DbSet<User> Users { get; set; }

    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Login>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("login");

            entity.Property(e => e.UserId).HasColumnName("User_Id");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Shoe>(entity =>
        {
            entity.HasKey(e => e.ShoesId);

            entity.ToTable("shoes");

            entity.Property(e => e.ShoesId).HasColumnName("Shoes_id");
            entity.Property(e => e.AddedBy).HasColumnName("Added_by");
            entity.Property(e => e.AddedDate)
                .HasColumnType("date")
                .HasColumnName("Added_date");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("user");

            entity.Property(e => e.UserId).HasColumnName("User_id");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Fname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
