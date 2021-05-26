using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("shipper_item_detail")]
    public partial class ShipperItemDetail
    {
        public ShipperItemDetail()
        {
            ShipperItemCommodityDetails = new HashSet<ShipperItemCommodityDetail>();
        }

        [Key]
        [Column("BLOCK_CTL_HEADER")]
        public long BlockCtlHeader { get; set; }
        [Key]
        [Column("LINE_ITEM_DETAIL_ID")]
        public long LineItemDetailId { get; set; }
        [Required]
        [Column("RECORD_IDENTIFIER")]
        [StringLength(3)]
        public string RecordIdentifier { get; set; }
        [Column("EXP_INFORMATION_CODE")]
        [StringLength(2)]
        public string ExpInformationCode { get; set; }
        [Required]
        [Column("LINE_NUMBER")]
        [StringLength(4)]
        public string LineNumber { get; set; }
        [Column("COMMODITY_DESCRIPTION")]
        [StringLength(45)]
        public string CommodityDescription { get; set; }
        [Required]
        [Column("FILING_ACTION_REQUEST")]
        [StringLength(1)]
        public string FilingActionRequest { get; set; }
        [Column("LICENSE_CODE")]
        [StringLength(3)]
        public string LicenseCode { get; set; }
        [Column("FOREIGN_DOMESTIC_ORIGIN")]
        [StringLength(1)]
        public string ForeignDomesticOrigin { get; set; }

        [ForeignKey(nameof(BlockCtlHeader))]
        [InverseProperty(nameof(ShipperBlockControlHeader.ShipperItemDetails))]
        public virtual ShipperBlockControlHeader BlockCtlHeaderNavigation { get; set; }
        [InverseProperty(nameof(ShipperItemCommodityDetail.ShipperItemDetail))]
        public virtual ICollection<ShipperItemCommodityDetail> ShipperItemCommodityDetails { get; set; }
    }
}
