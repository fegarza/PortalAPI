using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("shipper_license_detail")]
    public partial class ShipperLicenseDetail
    {
        [Key]
        [Column("BLOCK_CTL_HEADER")]
        public long BlockCtlHeader { get; set; }
        [Key]
        [Column("LICESE_DETAIL_ID")]
        public long LiceseDetailId { get; set; }
        [Required]
        [Column("RECORD_IDENTIFIER")]
        [StringLength(3)]
        public string RecordIdentifier { get; set; }
        [Column("ITAR_EXEMPTION_NUMBER")]
        [StringLength(12)]
        public string ItarExemptionNumber { get; set; }
        [Column("REGISTRATION_NUMBER")]
        [StringLength(6)]
        public string RegistrationNumber { get; set; }
        [Required]
        [Column("SME_INDICATOR")]
        [StringLength(1)]
        public string SmeIndicator { get; set; }
        [Column("ELIGIBLE_PARTY_CERT")]
        [StringLength(1)]
        public string EligiblePartyCert { get; set; }
        [Required]
        [Column("USML_CATEGORY_CODE")]
        [StringLength(2)]
        public string UsmlCategoryCode { get; set; }
        [Required]
        [Column("UNIT_MEASURE_CODE")]
        [StringLength(3)]
        public string UnitMeasureCode { get; set; }
        [Column("QUANTITY", TypeName = "decimal(18, 0)")]
        public decimal Quantity { get; set; }
        [Column("LICENSE_LINE_NUMBER", TypeName = "numeric(18, 0)")]
        public decimal LicenseLineNumber { get; set; }

        [ForeignKey(nameof(BlockCtlHeader))]
        [InverseProperty(nameof(ShipperBlockControlHeader.ShipperLicenseDetails))]
        public virtual ShipperBlockControlHeader BlockCtlHeaderNavigation { get; set; }
    }
}
