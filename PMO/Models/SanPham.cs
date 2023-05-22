using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace PMO.Models
{
    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            TuLieux = new HashSet<TuLieu>();
        }

        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaSP { get; set; }

        public string TenSP { get; set; }

        public string LinkSP { get; set; }

        public string LinkFB { get; set; }

        public string LinkYT { get; set; }

        public string NguonNhac { get; set; }

        public string MoTa { get; set; }

        public string KhoaNganh { get; set; }

        [StringLength(50)]
        public string ThoiLuong { get; set; }

        public int? Producer { get; set; }

        public virtual NhanSu NhanSu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TuLieu> TuLieux { get; set; }
    }
}
