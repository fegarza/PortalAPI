using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("shipper_item_commodity_detail")]
    public partial class ShipperItemCommodityDetail
    {
        [Key]
        [Column("BLOCK_CTL_HEADER")]
        public long BlockCtlHeader { get; set; }
        [Key]
        [Column("LINE_ITEM_DETAIL_ID")]
        public long LineItemDetailId { get; set; }
        [Key]
        [Column("COMM_DETAIL_ID")]
        public long CommDetailId { get; set; }
        [Required]
        [Column("RECORD_IDENTIFIER")]
        [StringLength(3)]
        public string RecordIdentifier { get; set; }
        [Column("HTS_NUMBER")]
        [StringLength(10)]
        public string HtsNumber { get; set; }
        [Column("UNIT_MEASURE")]
        [StringLength(3)]
        public string UnitMeasure { get; set; }
        [Column("QUANTITY", TypeName = "decimal(18, 0)")]
        public decimal? Quantity { get; set; }
        [Column("VALUE_GOODS", TypeName = "decimal(18, 0)")]
        public decimal? ValueGoods { get; set; }
        [Column("UNIT_MEASURE2")]
        [StringLength(10)]
        public string UnitMeasure2 { get; set; }
        [Column("QUANTITY2", TypeName = "decimal(18, 0)")]
        public decimal? Quantity2 { get; set; }
        [Column("SHIPPING_WEIGHT", TypeName = "decimal(18, 0)")]
        public decimal? ShippingWeight { get; set; }
        [Column("ECCN")]
        [StringLength(5)]
        public string Eccn { get; set; }
        [Column("EXP_LICENSE_NUMBER")]
        [StringLength(12)]
        public string ExpLicenseNumber { get; set; }

        [ForeignKey("BlockCtlHeader,LineItemDetailId")]
        [InverseProperty("ShipperItemCommodityDetails")]
        public virtual ShipperItemDetail ShipperItemDetail { get; set; }
    }
}
