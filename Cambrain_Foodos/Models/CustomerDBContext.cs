using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Cambrain_Foodos.Models
{
    public partial class CustomerDBContext : DbContext
    {
        public CustomerDBContext()
        {
        }

        public CustomerDBContext(DbContextOptions<FoodOrderingSystemDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> customer { get; set; } = null!;

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
            modelBuilder.Entity<Customer>(entity =>
            {
               
                entity.Property(e => e.CustomerId)

                    .HasColumnName("customer_id");

                entity.ToTable("Customer");

                entity.Property(e => e.Name)
                 .HasMaxLength(255)
                 .IsUnicode(false)
                .HasColumnName("name");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("phone_number");

                entity.Property(e => e.Address)
                   .HasMaxLength(255)
                   .IsUnicode(false)
                   .HasColumnName("address");

                entity.Property(e => e.UserName)
                 .HasMaxLength(255)
                 .IsUnicode(false)
                 .HasColumnName("user_name");

                entity.Property(e => e.Password)
                 .HasMaxLength(255)
                 .IsUnicode(false)
                 .HasColumnName("password");

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
