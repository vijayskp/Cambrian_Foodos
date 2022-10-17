using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Cambrain_Foodos.Models
{
    public partial class ItemDBContext : DbContext
    {
        public ItemDBContext()
        {
        }

        public ItemDBContext(DbContextOptions<FoodOrderingSystemDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<order_details> orderDetails { get; set; } = null!;

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
            modelBuilder.Entity<order_details>(entity =>
            {
               
                entity.Property(e => e.RecordId)

                    .HasColumnName("record_id");

                entity.ToTable("order_details");

                entity.Property(e => e.ItemName)
                 .HasMaxLength(255)
                 .IsUnicode(false)
                .HasColumnName("item_name");

                entity.Property(e => e.ItemPrice)
                    
                    .HasColumnName("item_price");

                entity.Property(e => e.Quantity)
                    
                    .HasColumnName("quantity");

                
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
