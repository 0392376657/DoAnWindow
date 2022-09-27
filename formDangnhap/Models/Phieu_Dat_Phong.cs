namespace formDangnhap.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Phieu_Dat_Phong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phieu_Dat_Phong()
        {
            CT_PDP = new HashSet<CT_PDP>();
        }

        [Key]
        [StringLength(50)]
        public string SoPhieuDP { get; set; }

        [Required]
        [StringLength(50)]
        public string MaKH { get; set; }

        public DateTime NgayDat { get; set; }

        public long TienCoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PDP> CT_PDP { get; set; }

        public virtual Khach_Hang Khach_Hang { get; set; }
    }
}
