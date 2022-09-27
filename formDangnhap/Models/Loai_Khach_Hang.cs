namespace formDangnhap.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Loai_Khach_Hang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Loai_Khach_Hang()
        {
            Khach_Hang = new HashSet<Khach_Hang>();
        }

        [Key]
        [StringLength(50)]
        public string MaLKH { get; set; }

        [Required]
        [StringLength(50)]
        public string TenLKH { get; set; }

        [Required]
        [StringLength(50)]
        public string GiamGia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Khach_Hang> Khach_Hang { get; set; }
    }
}
