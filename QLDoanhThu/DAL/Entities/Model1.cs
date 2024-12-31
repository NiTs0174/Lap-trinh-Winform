using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL.Entities
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<CAUTHU> CAUTHUs { get; set; }
        public virtual DbSet<DOIBONG> DOIBONGs { get; set; }
        public virtual DbSet<NHATAITRO> NHATAITROes { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOANs { get; set; }
        public virtual DbSet<TRANDAU> TRANDAUs { get; set; }
        public virtual DbSet<VE> VEs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DOIBONG>()
                .HasMany(e => e.CAUTHUs)
                .WithRequired(e => e.DOIBONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DOIBONG>()
                .HasMany(e => e.TRANDAUs)
                .WithRequired(e => e.DOIBONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TRANDAU>()
                .HasMany(e => e.VEs)
                .WithRequired(e => e.TRANDAU)
                .WillCascadeOnDelete(false);
        }
    }
}
