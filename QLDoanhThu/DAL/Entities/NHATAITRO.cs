namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHATAITRO")]
    public partial class NHATAITRO
    {
        [Key]
        [StringLength(50)]
        public string MaNTT { get; set; }

        [Required]
        [StringLength(50)]
        public string TenNTT { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        [StringLength(50)]
        public string SDT { get; set; }

        public double? SoTienTT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayTT { get; set; }
    }
}
