using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("po_receiver")]
    public partial class PoReceiver
    {
        [Key]
        [Column("id_poreceiver")]
        public long IdPoreceiver { get; set; }
        [Key]
        [Column("id_auto")]
        public int IdAuto { get; set; }
        [Column("location")]
        [StringLength(10)]
        public string Location { get; set; }
        [Column("from_store")]
        [StringLength(120)]
        public string FromStore { get; set; }
        [Column("store_name")]
        [StringLength(120)]
        public string StoreName { get; set; }
        [Column("transfer_number")]
        [StringLength(12)]
        public string TransferNumber { get; set; }
        [Column("po_number")]
        [StringLength(15)]
        public string PoNumber { get; set; }
        [Column("receipt_date", TypeName = "datetime")]
        public DateTime? ReceiptDate { get; set; }
        [Column("receiver_number")]
        [StringLength(15)]
        public string ReceiverNumber { get; set; }
        [Column("vendor_number")]
        [StringLength(6)]
        public string VendorNumber { get; set; }
        [Column("vendor_name")]
        [StringLength(120)]
        public string VendorName { get; set; }
        [Column("bill_of_lading")]
        [StringLength(20)]
        public string BillOfLading { get; set; }
        [Column("cartons_received")]
        public int? CartonsReceived { get; set; }
        [Column("cartons_demaged")]
        public int? CartonsDemaged { get; set; }
        [Column("carrier_number")]
        [StringLength(5)]
        public string CarrierNumber { get; set; }
        [Column("primary_upc")]
        [StringLength(20)]
        public string PrimaryUpc { get; set; }
        [Column("sku_number")]
        [StringLength(20)]
        public string SkuNumber { get; set; }
        [Column("item_description")]
        [StringLength(250)]
        public string ItemDescription { get; set; }
        [Column("qty_ordered", TypeName = "decimal(18, 2)")]
        public decimal? QtyOrdered { get; set; }
        [Column("qty_received", TypeName = "decimal(18, 2)")]
        public decimal? QtyReceived { get; set; }
        [Column("freight_carrier")]
        [StringLength(40)]
        public string FreightCarrier { get; set; }
        [Column("case_pack", TypeName = "decimal(18, 4)")]
        public decimal? CasePack { get; set; }
        [Column("transfer_cost", TypeName = "decimal(18, 4)")]
        public decimal? TransferCost { get; set; }
        [Column("ext_transfer_cost", TypeName = "decimal(18, 4)")]
        public decimal? ExtTransferCost { get; set; }
    }
}
