namespace formDangnhap.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Phieu_Trang_Bi
    {
        [Key]
        [StringLength(50)]
        public string SoPhieu { get; set; }

        [Required]
        [StringLength(50)]
        public string SoPhong { get; set; }

        public DateTime NgayTrangBi { get; set; }

        public virtual CT_TrangBi CT_TrangBi { get; set; }

        public virtual Phong Phong { get; set; }
    }
}
