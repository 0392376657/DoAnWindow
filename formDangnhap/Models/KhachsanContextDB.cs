using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace formDangnhap.Models
{
    public partial class KhachsanContextDB : DbContext
    {
        public KhachsanContextDB()
            : base("name=KhachsanContextDB")
        {
        }

        public virtual DbSet<Ca_Lam_Viec> Ca_Lam_Viec { get; set; }
        public virtual DbSet<CT_LuongNV> CT_LuongNV { get; set; }
        public virtual DbSet<CT_PDP> CT_PDP { get; set; }
        public virtual DbSet<CT_PDV> CT_PDV { get; set; }
        public virtual DbSet<CT_TrangBi> CT_TrangBi { get; set; }
        public virtual DbSet<Dich_Vu> Dich_Vu { get; set; }
        public virtual DbSet<Hoa_Don> Hoa_Don { get; set; }
        public virtual DbSet<Khach_Hang> Khach_Hang { get; set; }
        public virtual DbSet<Loai_Khach_Hang> Loai_Khach_Hang { get; set; }
        public virtual DbSet<Nhan_Vien> Nhan_Vien { get; set; }
        public virtual DbSet<Phieu_Dat_Phong> Phieu_Dat_Phong { get; set; }
        public virtual DbSet<Phieu_Dich_Vu> Phieu_Dich_Vu { get; set; }
        public virtual DbSet<Phieu_Trang_Bi> Phieu_Trang_Bi { get; set; }
        public virtual DbSet<Phieuu_Den_Bu> Phieuu_Den_Bu { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ca_Lam_Viec>()
                .Property(e => e.MaCLV)
                .IsUnicode(false);

            modelBuilder.Entity<Ca_Lam_Viec>()
                .HasMany(e => e.CT_LuongNV)
                .WithRequired(e => e.Ca_Lam_Viec)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CT_LuongNV>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<CT_LuongNV>()
                .Property(e => e.MaCLV)
                .IsUnicode(false);

            modelBuilder.Entity<CT_PDP>()
                .Property(e => e.SoPhong)
                .IsUnicode(false);

            modelBuilder.Entity<CT_PDP>()
                .Property(e => e.SoPhieuDP)
                .IsUnicode(false);

            modelBuilder.Entity<CT_PDP>()
                .HasMany(e => e.Hoa_Don)
                .WithRequired(e => e.CT_PDP)
                .HasForeignKey(e => new { e.SoPhong, e.SoPhieuDP })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CT_PDP>()
                .HasMany(e => e.Phieuu_Den_Bu)
                .WithRequired(e => e.CT_PDP)
                .HasForeignKey(e => new { e.SoPhong, e.SoPhieuDP })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CT_PDV>()
                .Property(e => e.SoPhieuDV)
                .IsUnicode(false);

            modelBuilder.Entity<CT_PDV>()
                .Property(e => e.MaDV)
                .IsUnicode(false);

            modelBuilder.Entity<CT_TrangBi>()
                .Property(e => e.SoPhieu)
                .IsUnicode(false);

            modelBuilder.Entity<CT_TrangBi>()
                .HasOptional(e => e.Phieu_Trang_Bi)
                .WithRequired(e => e.CT_TrangBi);

            modelBuilder.Entity<Dich_Vu>()
                .Property(e => e.MaDV)
                .IsUnicode(false);

            modelBuilder.Entity<Dich_Vu>()
                .HasMany(e => e.CT_PDV)
                .WithRequired(e => e.Dich_Vu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Hoa_Don>()
                .Property(e => e.SoHD)
                .IsUnicode(false);

            modelBuilder.Entity<Hoa_Don>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<Hoa_Don>()
                .Property(e => e.SoPhong)
                .IsUnicode(false);

            modelBuilder.Entity<Hoa_Don>()
                .Property(e => e.SoPhieuDP)
                .IsUnicode(false);

            modelBuilder.Entity<Hoa_Don>()
                .HasMany(e => e.Phieu_Dich_Vu)
                .WithRequired(e => e.Hoa_Don)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Khach_Hang>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<Khach_Hang>()
                .Property(e => e.MaLKH)
                .IsUnicode(false);

            modelBuilder.Entity<Khach_Hang>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<Khach_Hang>()
                .HasMany(e => e.Phieu_Dat_Phong)
                .WithRequired(e => e.Khach_Hang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Loai_Khach_Hang>()
                .Property(e => e.MaLKH)
                .IsUnicode(false);

            modelBuilder.Entity<Loai_Khach_Hang>()
                .HasMany(e => e.Khach_Hang)
                .WithRequired(e => e.Loai_Khach_Hang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Nhan_Vien>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<Nhan_Vien>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<Nhan_Vien>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<Nhan_Vien>()
                .HasMany(e => e.CT_LuongNV)
                .WithRequired(e => e.Nhan_Vien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Nhan_Vien>()
                .HasMany(e => e.Hoa_Don)
                .WithRequired(e => e.Nhan_Vien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Phieu_Dat_Phong>()
                .Property(e => e.SoPhieuDP)
                .IsUnicode(false);

            modelBuilder.Entity<Phieu_Dat_Phong>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<Phieu_Dat_Phong>()
                .HasMany(e => e.CT_PDP)
                .WithRequired(e => e.Phieu_Dat_Phong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Phieu_Dich_Vu>()
                .Property(e => e.SoPhieuDV)
                .IsUnicode(false);

            modelBuilder.Entity<Phieu_Dich_Vu>()
                .Property(e => e.SoPhong)
                .IsUnicode(false);

            modelBuilder.Entity<Phieu_Dich_Vu>()
                .Property(e => e.SoHD)
                .IsUnicode(false);

            modelBuilder.Entity<Phieu_Dich_Vu>()
                .HasMany(e => e.CT_PDV)
                .WithRequired(e => e.Phieu_Dich_Vu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Phieu_Trang_Bi>()
                .Property(e => e.SoPhieu)
                .IsUnicode(false);

            modelBuilder.Entity<Phieu_Trang_Bi>()
                .Property(e => e.SoPhong)
                .IsUnicode(false);

            modelBuilder.Entity<Phieuu_Den_Bu>()
                .Property(e => e.SoPhieuDenBu)
                .IsUnicode(false);

            modelBuilder.Entity<Phieuu_Den_Bu>()
                .Property(e => e.SoPhong)
                .IsUnicode(false);

            modelBuilder.Entity<Phieuu_Den_Bu>()
                .Property(e => e.SoPhieuDP)
                .IsUnicode(false);

            modelBuilder.Entity<Phong>()
                .Property(e => e.SoPhong)
                .IsUnicode(false);

            modelBuilder.Entity<Phong>()
                .HasMany(e => e.CT_PDP)
                .WithRequired(e => e.Phong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Phong>()
                .HasMany(e => e.Phieu_Dich_Vu)
                .WithRequired(e => e.Phong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Phong>()
                .HasMany(e => e.Phieu_Trang_Bi)
                .WithRequired(e => e.Phong)
                .WillCascadeOnDelete(false);
        }
    }
}
