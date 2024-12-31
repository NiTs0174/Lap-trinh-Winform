namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VE")]
    public partial class VE
    {
        [Key]
        [StringLength(50)]
        public string MaVe { get; set; }

        [Required]
        [StringLength(50)]
        public string MaTD { get; set; }

        public double? GiaVe { get; set; }

        public int? SLVeDaBan { get; set; }

        public virtual TRANDAU TRANDAU { get; set; }
    }
}
