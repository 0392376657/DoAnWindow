namespace formDangnhap.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Dich_Vu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dich_Vu()
        {
            CT_PDV = new HashSet<CT_PDV>();
        }

        [Key]
        [StringLength(50)]
        public string MaDV { get; set; }

        [Required]
        [StringLength(250)]
        public string TenDV { get; set; }

        [Required]
        [StringLength(50)]
        public string DVT { get; set; }

        public long DongGiaDV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PDV> CT_PDV { get; set; }
    }
}
