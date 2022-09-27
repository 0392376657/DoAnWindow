namespace formDangnhap.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Khach_Hang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Khach_Hang()
        {
            Phieu_Dat_Phong = new HashSet<Phieu_Dat_Phong>();
        }

        [Key]
        [StringLength(50)]
        public string MaKH { get; set; }

        [Required]
        [StringLength(50)]
        public string MaLKH { get; set; }

        [Required]
        [StringLength(50)]
        public string TenKH { get; set; }

        [Required]
        [StringLength(50)]
        public string QuocTich { get; set; }

        [Required]
        [StringLength(20)]
        public string SDT { get; set; }

        public virtual Loai_Khach_Hang Loai_Khach_Hang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phieu_Dat_Phong> Phieu_Dat_Phong { get; set; }
    }
}
