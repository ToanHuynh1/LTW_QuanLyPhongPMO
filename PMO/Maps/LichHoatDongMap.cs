using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using PMO.Models;

namespace PMO.Maps
{
    public class LichHoatDongMap : EntityTypeConfiguration<LichHoatDong>
    {
        public LichHoatDongMap()
        {
            HasMany(e => e.HoatDongNhanSus)
                .WithRequired(e => e.LichHoatDong)
                .WillCascadeOnDelete(false);
            HasMany(e => e.HoatDongThietBis)
                .WithRequired(e => e.LichHoatDong)
                .WillCascadeOnDelete(false);
        }

    }
}
