using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using PMO.Maps;
using PMO.Models;

namespace PMO
{
    public class Context : DbContext
    {
        public Context()
           : base("name=pmo")
        {

        }

        public virtual DbSet<CapDoTL> CapDoTLs { get; set; }
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<DangNhap> DangNhaps { get; set; }
        public virtual DbSet<DiaDiem> DiaDiems { get; set; }
        public virtual DbSet<HoatDongNhanSu> HoatDongNhanSus { get; set; }
        public virtual DbSet<HoatDongThietBi> HoatDongThietBis { get; set; }
        public virtual DbSet<LichHoatDong> LichHoatDongs { get; set; }
        public virtual DbSet<LoaiHoatDong> LoaiHoatDongs { get; set; }
        public virtual DbSet<LoaiThietBi> LoaiThietBis { get; set; }
        public virtual DbSet<NhanSu> NhanSus { get; set; }
        public virtual DbSet<NhiemVu> NhiemVus { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<ThietBi> ThietBis { get; set; }
        public virtual DbSet<TrangThai> TrangThais { get; set; }
        public virtual DbSet<TuLieu> TuLieus { get; set; }







        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CapDoTLMap());
            modelBuilder.Configurations.Add(new NhanSuMap());
            modelBuilder.Configurations.Add(new LichHoatDongMap()); 
            modelBuilder.Configurations.Add(new NhiemVuMap());
            modelBuilder.Configurations.Add(new DiaDiemMap());
            modelBuilder.Configurations.Add(new ThietBiMap());
            modelBuilder.Configurations.Add(new TrangThaiMap());

         
           
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
    }
}
