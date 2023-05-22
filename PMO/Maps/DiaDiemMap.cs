using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using PMO.Models;

namespace PMO.Maps
{
    public class DiaDiemMap: EntityTypeConfiguration<DiaDiem>
    {
        public DiaDiemMap()
        {
            HasMany(e => e.LichHoatDongs)
                .WithOptional(e => e.DiaDiem1)
                .HasForeignKey(e => e.DiaDiem);
        }
    }
}
