using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("shipper_shipment_cs1")]
    public partial class ShipperShipmentCs1
    {
        [Key]
        [Column("BLOCK_CTL_HEADER")]
        public long BlockCtlHeader { get; set; }
        [Key]
        [Column("SHIPMENT_SC1_ID")]
        public long ShipmentSc1Id { get; set; }
        [Required]
        [Column("RECORD_IDENTIFIER")]
        [StringLength(3)]
        public string RecordIdentifier { get; set; }
        [Column("RELATED_COMPANY_IND")]
        [StringLength(1)]
        public string RelatedCompanyInd { get; set; }
        [Column("MOT")]
        [StringLength(2)]
        public string Mot { get; set; }
        [Column("COUNTRY_ULT_DEST_CODE")]
        [StringLength(2)]
        public string CountryUltDestCode { get; set; }
        [Column("US_STATE_ORIGIN")]
        [StringLength(2)]
        public string UsStateOrigin { get; set; }
        [Column("CARRIER_ID")]
        [StringLength(4)]
        public string CarrierId { get; set; }
        [Required]
        [Column("SHIPMENT_REF_NUMBER")]
        [StringLength(17)]
        public string ShipmentRefNumber { get; set; }
        [Required]
        [Column("FILING_ACTION_REQUEST")]
        [StringLength(1)]
        public string FilingActionRequest { get; set; }
        [Column("CONVEYANCE_CARRIER_NAME")]
        [StringLength(23)]
        public string ConveyanceCarrierName { get; set; }
        [Column("FILING_OPTION_INDICATOR")]
        [StringLength(1)]
        public string FilingOptionIndicator { get; set; }
        [Column("PORT_UNLADING_CODE")]
        [StringLength(5)]
        public string PortUnladingCode { get; set; }
        [Column("PORT_EXPORTATION_CODE")]
        [StringLength(4)]
        public string PortExportationCode { get; set; }
        [Column("ESTIMATED_DATE_EXPORT", TypeName = "datetime")]
        public DateTime? EstimatedDateExport { get; set; }
        [Column("HAZMAT")]
        [StringLength(1)]
        public string Hazmat { get; set; }

        [ForeignKey(nameof(BlockCtlHeader))]
        [InverseProperty(nameof(ShipperBlockControlHeader.ShipperShipmentCs1s))]
        public virtual ShipperBlockControlHeader BlockCtlHeaderNavigation { get; set; }
    }
}
