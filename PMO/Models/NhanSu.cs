using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace PMO.Models
{
    [Table("NhanSu")]
    public partial class NhanSu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanSu()
        {
            HoatDongNhanSus = new HashSet<HoatDongNhanSu>();
            SanPhams = new HashSet<SanPham>();
        }

        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaNS { get; set; }

        public string HoTen { get; set; }

        [StringLength(50)]
        public string CMND { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(11)]
        public string SDT { get; set; }

        [StringLength(9)]
        public string MSSV { get; set; }
        [StringLength(3)]
        public string Phai { get; set; }

        public int? MaCV { get; set; }

        public string LinkFB { get; set; }

        public virtual ChucVu ChucVu { get; set; }

        public virtual DangNhap DangNhap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoatDongNhanSu> HoatDongNhanSus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
