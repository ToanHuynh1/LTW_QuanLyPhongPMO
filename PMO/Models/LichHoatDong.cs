using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace PMO.Models
{
    [Table("LichHoatDong")]
    public partial class LichHoatDong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LichHoatDong()
        {
            HoatDongNhanSus = new HashSet<HoatDongNhanSu>();
            HoatDongThietBis = new HashSet<HoatDongThietBi>();
            TuLieus = new HashSet<TuLieu>();
        }

        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHD { get; set; }

        public DateTime? NgayMuon { get; set; }

        public DateTime? NgayTra { get; set; }

        public string TenHD { get; set; }

        public int? DiaDiem { get; set; }

        public int? MaLoaiHD { get; set; }

        public int? TrangThai { get; set; }

        public virtual DiaDiem DiaDiem1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoatDongNhanSu> HoatDongNhanSus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoatDongThietBi> HoatDongThietBis { get; set; }

        public virtual LoaiHoatDong LoaiHoatDong { get; set; }

        public virtual TrangThai TrangThai1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TuLieu> TuLieus { get; set; }
    }
}
