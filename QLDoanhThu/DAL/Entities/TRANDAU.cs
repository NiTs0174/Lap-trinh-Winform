namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TRANDAU")]
    public partial class TRANDAU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TRANDAU()
        {
            VEs = new HashSet<VE>();
        }

        [Key]
        [StringLength(50)]
        public string MaTD { get; set; }

        [Required]
        [StringLength(50)]
        public string MaDB { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayTD { get; set; }

        [StringLength(50)]
        public string GioTD { get; set; }

        [StringLength(50)]
        public string SVD { get; set; }

        public virtual DOIBONG DOIBONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VE> VEs { get; set; }
    }
}
