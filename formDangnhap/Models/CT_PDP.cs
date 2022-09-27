namespace formDangnhap.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_PDP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CT_PDP()
        {
            Hoa_Don = new HashSet<Hoa_Don>();
            Phieuu_Den_Bu = new HashSet<Phieuu_Den_Bu>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string SoPhong { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string SoPhieuDP { get; set; }

        public DateTime NgayNhanPhong { get; set; }

        public DateTime NgayTraDuKien { get; set; }

        public long GiaPhong { get; set; }

        public virtual Phieu_Dat_Phong Phieu_Dat_Phong { get; set; }

        public virtual Phong Phong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hoa_Don> Hoa_Don { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phieuu_Den_Bu> Phieuu_Den_Bu { get; set; }
    }
}
