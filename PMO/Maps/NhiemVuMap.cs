using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using PMO.Models;

namespace PMO.Maps
{
    public class NhiemVuMap: EntityTypeConfiguration<NhiemVu>
    {
        public NhiemVuMap()
        {
            HasMany(e => e.HoatDongNhanSus)
                .WithRequired(e => e.NhiemVu)
                .WillCascadeOnDelete(false);

        }
    }
}
