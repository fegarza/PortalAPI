using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("shipper_block_control_header")]
    [Index(nameof(BatchCtlHeader), Name = "IX_shipper_block_control_header", IsUnique = true)]
    public partial class ShipperBlockControlHeader
    {
        public ShipperBlockControlHeader()
        {
            ShipperItemDetails = new HashSet<ShipperItemDetail>();
            ShipperLicenseDetails = new HashSet<ShipperLicenseDetail>();
            ShipperPartyHeaders = new HashSet<ShipperPartyHeader>();
            ShipperShipmentCs1s = new HashSet<ShipperShipmentCs1>();
            ShipperShipmentCs2s = new HashSet<ShipperShipmentCs2>();
            ShipperTransportationDetails = new HashSet<ShipperTransportationDetail>();
        }

        [Column("BATCH_CTL_HEADER")]
        public long BatchCtlHeader { get; set; }
        [Key]
        [Column("BLOCK_CTL_HEADER")]
        public long BlockCtlHeader { get; set; }
        [Required]
        [Column("RECORD_IDENTIFIER")]
        [StringLength(1)]
        public string RecordIdentifier { get; set; }
        [Required]
        [Column("USPPI_ID")]
        [StringLength(11)]
        public string UsppiId { get; set; }
        [Required]
        [Column("USPPI_ID_TYPE")]
        [StringLength(1)]
        public string UsppiIdType { get; set; }
        [Required]
        [Column("USPPI_NAME")]
        [StringLength(30)]
        public string UsppiName { get; set; }
        [Column("id_proveedor")]
        [StringLength(6)]
        public string IdProveedor { get; set; }

        [ForeignKey(nameof(BatchCtlHeader))]
        [InverseProperty(nameof(ShipperBatchControlHeader.ShipperBlockControlHeader))]
        public virtual ShipperBatchControlHeader BatchCtlHeaderNavigation { get; set; }
        [InverseProperty(nameof(ShipperItemDetail.BlockCtlHeaderNavigation))]
        public virtual ICollection<ShipperItemDetail> ShipperItemDetails { get; set; }
        [InverseProperty(nameof(ShipperLicenseDetail.BlockCtlHeaderNavigation))]
        public virtual ICollection<ShipperLicenseDetail> ShipperLicenseDetails { get; set; }
        [InverseProperty(nameof(ShipperPartyHeader.BlockCtlHeaderNavigation))]
        public virtual ICollection<ShipperPartyHeader> ShipperPartyHeaders { get; set; }
        [InverseProperty(nameof(ShipperShipmentCs1.BlockCtlHeaderNavigation))]
        public virtual ICollection<ShipperShipmentCs1> ShipperShipmentCs1s { get; set; }
        [InverseProperty(nameof(ShipperShipmentCs2.BlockCtlHeaderNavigation))]
        public virtual ICollection<ShipperShipmentCs2> ShipperShipmentCs2s { get; set; }
        [InverseProperty(nameof(ShipperTransportationDetail.BlockCtlHeaderNavigation))]
        public virtual ICollection<ShipperTransportationDetail> ShipperTransportationDetails { get; set; }
    }
}
