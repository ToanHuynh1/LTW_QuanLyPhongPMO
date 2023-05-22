using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace PMO.Models
{
    [Table("ThietBi")]
    public partial class ThietBi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThietBi()
        {
            HoatDongThietBis = new HashSet<HoatDongThietBi>();
        }

        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaTB { get; set; }

        public int? MaLoaiTB { get; set; }

        public string TenTB { get; set; }

        public int? SoLuong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoatDongThietBi> HoatDongThietBis { get; set; }

        public virtual LoaiThietBi LoaiThietBi { get; set; }
    }
}
