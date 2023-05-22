using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using PMO.Models;

namespace PMO.Maps
{
    public class NhanSuMap: EntityTypeConfiguration<NhanSu>
    {
        public NhanSuMap()
        {
            //HasMany(p => p.HoatDongNhanSus)
            //     .WithRequired()
            //     .HasForeignKey(ph => ph.MaNS);
            ///*HasMany(p => p.lichHoatDongs)
            //     .WithMany(c => c.NhanSus)
            //     .Map(m =>
            //     {
            //         m.MapLeftKey("MaNS");
            //         m.MapRightKey("MaHD");
            //     });*/
            //HasMany(p => p.SanPhams)
            //    .WithRequired()
            //    .HasForeignKey(ph => ph.Producer);
            //HasMany(p => p.DangNhaps)
            //    .WithRequired()
            //    .HasForeignKey(ph => ph.MaNS);
            /*HasMany(p => p.dangNhaps)
                .WithRequired()
                .HasForeignKey(ph => ph.MaNS);*/
            HasOptional(e => e.DangNhap)
                .WithRequired(e => e.NhanSu);
            HasMany(e => e.HoatDongNhanSus)
                .WithRequired(e => e.NhanSu)
                .WillCascadeOnDelete(false);
            HasMany(e => e.SanPhams)
                .WithOptional(e => e.NhanSu)
                .HasForeignKey(e => e.Producer);

        }
    }
}
