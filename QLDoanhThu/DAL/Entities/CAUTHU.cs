namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CAUTHU")]
    public partial class CAUTHU
    {
        [Key]
        [StringLength(50)]
        public string MaCT { get; set; }

        [Required]
        [StringLength(50)]
        public string TenCT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(50)]
        public string NoiSinh { get; set; }

        [StringLength(50)]
        public string ViTri { get; set; }

        [Required]
        [StringLength(50)]
        public string MaDB { get; set; }

        public virtual DOIBONG DOIBONG { get; set; }
    }
}
