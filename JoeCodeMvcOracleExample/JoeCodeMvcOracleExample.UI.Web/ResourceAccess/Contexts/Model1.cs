namespace JoeCodeMvcOracleExample.UI.Web.ResourceAccess.Contexts
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using JoeCodeMvcOracleExample.UI.Web.ResourceAccess.Entities;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<IRCS_ARR_EXFLT> IRCS_ARR_EXFLT { get; set; }
        public virtual DbSet<IRCS_ARR_FLT_CARRIER> IRCS_ARR_FLT_CARRIER { get; set; }
        public virtual DbSet<IRCS_ARR_FLT_CODESHARE> IRCS_ARR_FLT_CODESHARE { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IRCS_ARR_EXFLT>()
                .Property(e => e.IRCS_FLT_NBR)
                .IsUnicode(false);

            modelBuilder.Entity<IRCS_ARR_EXFLT>()
                .Property(e => e.IRCS_FLT_ARR_STN)
                .IsUnicode(false);

            modelBuilder.Entity<IRCS_ARR_EXFLT>()
                .Property(e => e.IRCS_FLT_CARRIER_CREATE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<IRCS_ARR_EXFLT>()
                .Property(e => e.IRCS_FLT_CARRIER_UPDATE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<IRCS_ARR_FLT_CARRIER>()
                .Property(e => e.IRCS_FLT_CARRIER_CD)
                .IsUnicode(false);

            modelBuilder.Entity<IRCS_ARR_FLT_CARRIER>()
                .Property(e => e.IRCS_FLT_CARRIER_EN)
                .IsUnicode(false);

            modelBuilder.Entity<IRCS_ARR_FLT_CARRIER>()
                .Property(e => e.IRCS_FLT_CARRIER_CN)
                .IsUnicode(false);

            modelBuilder.Entity<IRCS_ARR_FLT_CARRIER>()
                .Property(e => e.IRCS_FLT_CARRIER_CREATE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<IRCS_ARR_FLT_CARRIER>()
                .Property(e => e.IRCS_FLT_CARRIER_UPDATE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<IRCS_ARR_FLT_CARRIER>()
                .Property(e => e.IRCS_FLT_CARRIER_STN)
                .IsUnicode(false);

            modelBuilder.Entity<IRCS_ARR_FLT_CODESHARE>()
                .Property(e => e.IRCS_FLT_NBR)
                .IsUnicode(false);

            modelBuilder.Entity<IRCS_ARR_FLT_CODESHARE>()
                .Property(e => e.IRCS_FLT_ARR_STN)
                .IsUnicode(false);

            modelBuilder.Entity<IRCS_ARR_FLT_CODESHARE>()
                .Property(e => e.IRCS_FLT_CARRIER_CREATE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<IRCS_ARR_FLT_CODESHARE>()
                .Property(e => e.IRCS_FLT_CARRIER_UPDATE_ID)
                .IsUnicode(false);
        }
    }
}
