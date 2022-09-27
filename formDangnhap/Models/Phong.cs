namespace formDangnhap.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Phong")]
    public partial class Phong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phong()
        {
            CT_PDP = new HashSet<CT_PDP>();
            Phieu_Dich_Vu = new HashSet<Phieu_Dich_Vu>();
            Phieu_Trang_Bi = new HashSet<Phieu_Trang_Bi>();
        }

        [Key]
        [StringLength(50)]
        public string SoPhong { get; set; }

        [Required]
        [StringLength(50)]
        public string LoaiPhong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PDP> CT_PDP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phieu_Dich_Vu> Phieu_Dich_Vu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phieu_Trang_Bi> Phieu_Trang_Bi { get; set; }
    }
}
