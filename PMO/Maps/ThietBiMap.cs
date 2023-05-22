using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using PMO.Models;

namespace PMO.Maps
{
    public class ThietBiMap : EntityTypeConfiguration<ThietBi>
    {
        public ThietBiMap()
        {
            HasMany(e => e.HoatDongThietBis)
                .WithRequired(e => e.ThietBi)
                .WillCascadeOnDelete(false);
            /* HasMany(p => p.LichHoatDongs)
                 .WithMany(c => c.ThietBis)
                 .Map(m =>
                {
                    m.MapLeftKey("MaTB");
                    m.MapRightKey("MaHD");

                });*/
        }
    }
}
