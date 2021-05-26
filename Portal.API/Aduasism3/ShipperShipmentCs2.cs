using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("shipper_shipment_cs2")]
    public partial class ShipperShipmentCs2
    {
        [Key]
        [Column("BLOCK_CTL_HEADER")]
        public long BlockCtlHeader { get; set; }
        [Key]
        [Column("SHIPMENT_CS2_ID")]
        public long ShipmentCs2Id { get; set; }
        [Required]
        [Column("RECORD_IDENTIFIER")]
        [StringLength(3)]
        public string RecordIdentifier { get; set; }
        [Required]
        [Column("INBOND_CODE")]
        [StringLength(2)]
        public string InbondCode { get; set; }
        [Column("ENTRY_NUMBER")]
        [StringLength(15)]
        public string EntryNumber { get; set; }
        [Column("FOREIGN_TRADE_ZONE_ID")]
        [StringLength(5)]
        public string ForeignTradeZoneId { get; set; }
        [Required]
        [Column("ROUTED_EXP_TRANSACT_IND")]
        [StringLength(1)]
        public string RoutedExpTransactInd { get; set; }

        [ForeignKey(nameof(BlockCtlHeader))]
        [InverseProperty(nameof(ShipperBlockControlHeader.ShipperShipmentCs2s))]
        public virtual ShipperBlockControlHeader BlockCtlHeaderNavigation { get; set; }
    }
}
