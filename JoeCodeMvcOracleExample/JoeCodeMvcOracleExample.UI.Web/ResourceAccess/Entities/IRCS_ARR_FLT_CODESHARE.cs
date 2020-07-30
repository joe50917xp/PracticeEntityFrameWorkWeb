namespace JoeCodeMvcOracleExample.UI.Web.ResourceAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IRCS.IRCS_ARR_FLT_CODESHARE")]
    public partial class IRCS_ARR_FLT_CODESHARE
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string IRCS_FLT_NBR { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string IRCS_FLT_ARR_STN { get; set; }

        [StringLength(10)]
        public string IRCS_FLT_CARRIER_CREATE_ID { get; set; }

        public DateTime? IRCS_FLT_CARRIER_CREATE_DT { get; set; }

        [StringLength(10)]
        public string IRCS_FLT_CARRIER_UPDATE_ID { get; set; }

        public DateTime? IRCS_FLT_CARRIER_UPDATE_DT { get; set; }
    }
}
