using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using PMO.Models;

namespace PMO.Maps
{
    public class SanPhamMap : EntityTypeConfiguration<SanPham>
    {
        public SanPhamMap()
        {
            HasMany(e => e.TuLieux)
                .WithMany(e => e.SanPhams)
                .Map(m => m.ToTable("TuLieuSanPham").MapLeftKey("MaSP").MapRightKey("MaTL"));
        }
    }
}
