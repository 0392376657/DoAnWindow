namespace formDangnhap.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_TrangBi
    {
        [Key]
        [StringLength(50)]
        public string SoPhieu { get; set; }

        [Required]
        [StringLength(50)]
        public string TinhTrang { get; set; }

        public virtual Phieu_Trang_Bi Phieu_Trang_Bi { get; set; }
    }
}
