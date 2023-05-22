using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using PMO.Models;

namespace PMO.Maps
{
    public class TrangThaiMap : EntityTypeConfiguration<TrangThai>
    {
        public TrangThaiMap()
        {
            HasMany(e => e.LichHoatDongs)
                .WithOptional(e => e.TrangThai1)
                .HasForeignKey(e => e.TrangThai);
        }
    }
}
