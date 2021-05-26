using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("shipper_transportation_detail")]
    public partial class ShipperTransportationDetail
    {
        [Key]
        [Column("BLOCK_CTL_HEADER")]
        public long BlockCtlHeader { get; set; }
        [Key]
        [Column("TRANSPORTATION_DETAIL_ID")]
        public long TransportationDetailId { get; set; }
        [Required]
        [Column("RECORD_IDENTIFIER")]
        [StringLength(3)]
        public string RecordIdentifier { get; set; }
        [Column("EQUIPMENT_NUMBER")]
        [StringLength(14)]
        public string EquipmentNumber { get; set; }
        [Column("SEAL_NUMBER")]
        [StringLength(15)]
        public string SealNumber { get; set; }
        [Column("TRANSP_REFERENCE_NUMBER")]
        [StringLength(30)]
        public string TranspReferenceNumber { get; set; }

        [ForeignKey(nameof(BlockCtlHeader))]
        [InverseProperty(nameof(ShipperBlockControlHeader.ShipperTransportationDetails))]
        public virtual ShipperBlockControlHeader BlockCtlHeaderNavigation { get; set; }
    }
}
