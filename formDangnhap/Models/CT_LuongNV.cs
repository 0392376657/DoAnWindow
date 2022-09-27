namespace formDangnhap.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_LuongNV
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string MaNV { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string MaCLV { get; set; }

        public int TongSoCaLam { get; set; }

        public long ThanhTien { get; set; }

        public virtual Ca_Lam_Viec Ca_Lam_Viec { get; set; }

        public virtual Nhan_Vien Nhan_Vien { get; set; }
    }
}
