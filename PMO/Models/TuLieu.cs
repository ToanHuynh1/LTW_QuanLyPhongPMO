using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace PMO.Models
{
    [Table("TuLieu")]
    public partial class TuLieu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TuLieu()
        {
            SanPhams = new HashSet<SanPham>();
        }

        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaTL { get; set; }

        public int? MaHD { get; set; }

        public DateTime? NgayQuayTL { get; set; }

        public int? MaCDTL { get; set; }

        public string TenTL { get; set; }

        public string LinkTL { get; set; }

        public virtual CapDoTL CapDoTL { get; set; }

        public virtual LichHoatDong LichHoatDong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
