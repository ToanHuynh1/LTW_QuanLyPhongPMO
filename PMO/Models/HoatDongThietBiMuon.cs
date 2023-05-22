using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace PMO.Models
{
    [Table("HoatDongThietBi")]
    public partial class HoatDongThietBi
    {
        [Key]
        [Column(Order = 0)]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHD { get; set; }

        [Key]
        [Column(Order = 1)]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaTB { get; set; }

        public int? SoLuong { get; set; }

        public virtual LichHoatDong LichHoatDong { get; set; }

        public virtual ThietBi ThietBi { get; set; }
    }
}
