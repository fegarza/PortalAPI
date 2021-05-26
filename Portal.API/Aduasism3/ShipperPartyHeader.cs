using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("shipper_party_header")]
    public partial class ShipperPartyHeader
    {
        [Key]
        [Column("BLOCK_CTL_HEADER")]
        public long BlockCtlHeader { get; set; }
        [Key]
        [Column("PARTY_HEADER_ID")]
        public long PartyHeaderId { get; set; }
        [Required]
        [Column("RECORD_IDENTIFIER")]
        [StringLength(3)]
        public string RecordIdentifier { get; set; }
        [Column("PARTY_ID")]
        [StringLength(11)]
        public string PartyId { get; set; }
        [Column("PARTY_ID_TYPE")]
        [StringLength(1)]
        public string PartyIdType { get; set; }
        [Required]
        [Column("PARTY_TYPE")]
        [StringLength(1)]
        public string PartyType { get; set; }
        [Column("PARTY_NAME")]
        [StringLength(30)]
        public string PartyName { get; set; }
        [Column("CONTACT_FIRST_NAME")]
        [StringLength(13)]
        public string ContactFirstName { get; set; }
        [Column("CONTACT_LAST_NAME")]
        [StringLength(20)]
        public string ContactLastName { get; set; }
        [Column("SOLD_ROUTE_INDICATOR")]
        [StringLength(1)]
        public string SoldRouteIndicator { get; set; }

        [ForeignKey(nameof(BlockCtlHeader))]
        [InverseProperty(nameof(ShipperBlockControlHeader.ShipperPartyHeaders))]
        public virtual ShipperBlockControlHeader BlockCtlHeaderNavigation { get; set; }
    }
}
