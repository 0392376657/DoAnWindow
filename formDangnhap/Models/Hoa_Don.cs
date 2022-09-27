namespace formDangnhap.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Hoa_Don
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hoa_Don()
        {
            Phieu_Dich_Vu = new HashSet<Phieu_Dich_Vu>();
        }

        [Key]
        [StringLength(50)]
        public string SoHD { get; set; }

        [Required]
        [StringLength(50)]
        public string MaNV { get; set; }

        public DateTime NgayThanhToan { get; set; }

        public long TongTienHD { get; set; }

        [Required]
        [StringLength(50)]
        public string SoPhong { get; set; }

        [Required]
        [StringLength(50)]
        public string SoPhieuDP { get; set; }

        public virtual CT_PDP CT_PDP { get; set; }

        public virtual Nhan_Vien Nhan_Vien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phieu_Dich_Vu> Phieu_Dich_Vu { get; set; }
    }
}
