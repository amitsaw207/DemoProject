using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebAPIProj.Models;

namespace WebAPIProj.Extensions
{
    public partial class APIDBContext : DbContext
    {
        public APIDBContext()
        {
        }

        public APIDBContext(DbContextOptions<APIDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-EUUQVOCP\\SQLEXPRESS;Initial Catalog=SDMS;User ID=amits1;Password=amit@123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Student");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date");

                entity.Property(e => e.SAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("S_Address");

                entity.Property(e => e.SClass)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("S_Class");

                entity.Property(e => e.SDiv)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("S_Div");

                entity.Property(e => e.SEmailId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("S_EmailID");

                entity.Property(e => e.SFname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("S_FName");

                entity.Property(e => e.SId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("S_ID");

                entity.Property(e => e.SLname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("S_LName");

                entity.Property(e => e.SMobileNo).HasColumnName("S_MobileNo");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_at");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Updated_at");

                entity.Property(e => e.UserName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
