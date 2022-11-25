using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ASM_1_NET103_LOITQPH26025.A.DAL.Models
{
    public partial class ASM1Context : DbContext
    {
        public ASM1Context()
        {
        }

        public ASM1Context(DbContextOptions<ASM1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<QuanLyDiemSinhVien> QuanLyDiemSinhViens { get; set; } = null!;
        public virtual DbSet<QuanLySinhVien> QuanLySinhViens { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-5359J6UA\\SQLEXPRESS;Initial Catalog=ASM1;User ID=loinet;Password=1234567");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Account");

                entity.Property(e => e.Pass)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pass");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<QuanLyDiemSinhVien>(entity =>
            {
                entity.HasKey(e => e.MaSv)
                    .HasName("PK__QuanLyDi__2725087AC2EF6EDE");

                entity.ToTable("QuanLyDiemSinhVien");

                entity.Property(e => e.MaSv)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DiemTb).HasColumnName("DiemTB");

                entity.Property(e => e.Gdtc).HasColumnName("GDTC");

                entity.Property(e => e.Ten).HasMaxLength(60);
            });

            modelBuilder.Entity<QuanLySinhVien>(entity =>
            {
                entity.HasKey(e => e.MaSv)
                    .HasName("PK__QuanLySi__2725087A3E9A9D74");

                entity.ToTable("QuanLySinhVien");

                entity.Property(e => e.MaSv)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Anh).HasColumnType("image");

                entity.Property(e => e.DiaChi).HasMaxLength(255);

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GioiTinh).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SDT");

                entity.Property(e => e.Ten).HasMaxLength(60);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
