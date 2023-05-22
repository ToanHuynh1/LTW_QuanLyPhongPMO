using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace PMO.Models
{
    [Table("DangNhap")]
    public partial class DangNhap
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaNS { get; set; }

        public string UserLogin { get; set; }

        public string PassLogin { get; set; }

        public virtual NhanSu NhanSu { get; set; }
    }
}
