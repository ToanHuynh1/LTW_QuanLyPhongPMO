using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using PMO.Models;

namespace PMO.Maps
{
    public class CapDoTLMap : EntityTypeConfiguration<CapDoTL>
    {
        public CapDoTLMap()
        {
            HasMany(e => e.TuLieus)
                .WithOptional(e => e.CapDoTL)
                .HasForeignKey(e => e.MaCDTL);

            /*HasMany(p => p.sanPhams)
                .WithRequired()
                .HasForeignKey(ph => ph.MaCD);*/

        }
    }
}
