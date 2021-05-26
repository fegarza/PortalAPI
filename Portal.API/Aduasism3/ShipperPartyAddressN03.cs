using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("shipper_party_address_n03")]
    public partial class ShipperPartyAddressN03
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
        [Column("CITY")]
        [StringLength(25)]
        public string City { get; set; }
        [Column("STATE_CODE")]
        [StringLength(2)]
        public string StateCode { get; set; }
        [Column("COUNTRY_CODE")]
        [StringLength(2)]
        public string CountryCode { get; set; }
        [Column("POSTAL_CODE")]
        [StringLength(9)]
        public string PostalCode { get; set; }
        [Column("US_PPI_IRS_NUMBER")]
        [StringLength(9)]
        public string UsPpiIrsNumber { get; set; }
        [Column("US_PPIIRS_ID_TYPE")]
        [StringLength(1)]
        public string UsPpiirsIdType { get; set; }
    }
}
