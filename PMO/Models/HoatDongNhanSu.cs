using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace PMO.Models
{
    [Table("HoatDongNhanSu")]
    public partial class HoatDongNhanSu
    {
        [Key]
        [Column(Order = 0)]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHD { get; set; }

        [Key]
        [Column(Order = 1)]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaNS { get; set; }

        [Key]
        [Column(Order = 2)]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaNV { get; set; }

        public virtual LichHoatDong LichHoatDong { get; set; }

        public virtual NhanSu NhanSu { get; set; }

        public virtual NhiemVu NhiemVu { get; set; }
    }
}
