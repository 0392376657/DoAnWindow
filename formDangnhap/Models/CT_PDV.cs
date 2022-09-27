namespace formDangnhap.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_PDV
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string SoPhieuDV { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string MaDV { get; set; }

        public byte SoLuong { get; set; }

        public virtual Dich_Vu Dich_Vu { get; set; }

        public virtual Phieu_Dich_Vu Phieu_Dich_Vu { get; set; }
    }
}
