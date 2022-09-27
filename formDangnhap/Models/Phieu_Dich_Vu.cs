namespace formDangnhap.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Phieu_Dich_Vu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phieu_Dich_Vu()
        {
            CT_PDV = new HashSet<CT_PDV>();
        }

        [Key]
        [StringLength(50)]
        public string SoPhieuDV { get; set; }

        [Required]
        [StringLength(50)]
        public string SoPhong { get; set; }

        [Required]
        [StringLength(50)]
        public string SoHD { get; set; }

        public DateTime NgaySD { get; set; }

        public long TongTienDV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PDV> CT_PDV { get; set; }

        public virtual Hoa_Don Hoa_Don { get; set; }

        public virtual Phong Phong { get; set; }
    }
}
