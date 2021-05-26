using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("shipper_party_address_n02")]
    public partial class ShipperPartyAddressN02
    {
        [Key]
        [Column("BLOCK_CTL_HEADER")]
        public long BlockCtlHeader { get; set; }
        [Key]
        [Column("PARTY_ADDRESS_ID")]
        public long PartyAddressId { get; set; }
        [Key]
        [Column("PARTY_HEADER_ID")]
        public long PartyHeaderId { get; set; }
        [Required]
        [Column("RECORD_IDENTIFIER")]
        [StringLength(3)]
        public string RecordIdentifier { get; set; }
        [Required]
        [Column("ADDRESS_LINE_1")]
        [StringLength(32)]
        public string AddressLine1 { get; set; }
        [Column("ADDRESS_LINE_2")]
        [StringLength(32)]
        public string AddressLine2 { get; set; }
        [Column("CONTACT_PHONE_NUMBER")]
        [StringLength(13)]
        public string ContactPhoneNumber { get; set; }
    }
}
