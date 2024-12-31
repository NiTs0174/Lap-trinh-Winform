namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TAIKHOAN")]
    public partial class TAIKHOAN
    {
        [Key]
        [Column("TaiKhoan")]
        [StringLength(50)]
        public string TaiKhoan1 { get; set; }

        [StringLength(50)]
        public string TenNV { get; set; }

        [Required]
        [StringLength(50)]
        public string MatKhau { get; set; }

        [StringLength(50)]
        public string LoaiTK { get; set; }

        public TAIKHOAN()
        {
        }

        public TAIKHOAN(string tenTaiKhoan, string matKhau)
        {
            this.TaiKhoan1 = tenTaiKhoan;
            this.MatKhau = matKhau;
        }
    }
}
