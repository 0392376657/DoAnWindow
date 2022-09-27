namespace formDangnhap.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ca_Lam_Viec
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ca_Lam_Viec()
        {
            CT_LuongNV = new HashSet<CT_LuongNV>();
        }

        [Key]
        [StringLength(50)]
        public string MaCLV { get; set; }

        [Required]
        [StringLength(50)]
        public string TenCLV { get; set; }

        public DateTime GioBD { get; set; }

        public DateTime GioKT { get; set; }

        public long SoTien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_LuongNV> CT_LuongNV { get; set; }
    }
}
