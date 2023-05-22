using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace PMO.Models
{
    [Table("LoaiThietBi")]
    public partial class LoaiThietBi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiThietBi()
        {
            ThietBis = new HashSet<ThietBi>();
        }

        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaLoaiTB { get; set; }

        public string TenLoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThietBi> ThietBis { get; set; }
    }
}
