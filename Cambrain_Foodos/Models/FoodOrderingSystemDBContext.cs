﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Cambrain_Foodos.Models
{
    public partial class FoodOrderingSystemDBContext : DbContext
    {
        public FoodOrderingSystemDBContext()
        {
        }

        public FoodOrderingSystemDBContext(DbContextOptions<FoodOrderingSystemDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Restaurant> Restaurants { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:cambrian-fos.database.windows.net,1433;Initial Catalog=FoodOrderingSystemDB;Persist Security Info=False;User ID=A00257752;Password=Rohit@45;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Restaurant>(entity =>
            {
                entity.ToTable("restaurant");

                entity.Property(e => e.RestaurantId).HasColumnName("restaurant_id");

                entity.Property(e => e.Branch)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("branch");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("phone_number");

                entity.Property(e => e.RestaurantName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("restaurant_name");

                entity.Property(e => e.RestaurantImage)
                   .HasMaxLength(255)
                   .IsUnicode(false)
                   .HasColumnName("restaurant_image");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
