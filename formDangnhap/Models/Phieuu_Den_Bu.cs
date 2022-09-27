namespace formDangnhap.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Phieuu_Den_Bu
    {
        [Key]
        [StringLength(50)]
        public string SoPhieuDenBu { get; set; }

        [Required]
        [StringLength(50)]
        public string SoPhong { get; set; }

        [Required]
        [StringLength(50)]
        public string SoPhieuDP { get; set; }

        public DateTime NgayLap { get; set; }

        [Required]
        [StringLength(250)]
        public string LyDo { get; set; }

        [Required]
        [StringLength(250)]
        public string HinhThucDenBu { get; set; }

        public virtual CT_PDP CT_PDP { get; set; }
    }
}
