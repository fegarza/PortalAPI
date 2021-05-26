using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("shipper_batch_control_header")]
    [Index(nameof(IdTrafico), Name = "IX_shipper_batch_control_header_1", IsUnique = true)]
    public partial class ShipperBatchControlHeader
    {
        [Key]
        [Column("ID_BATCH_CTL_HEADER")]
        public long IdBatchCtlHeader { get; set; }
        [Required]
        [Column("ID_TRAFICO")]
        [StringLength(10)]
        public string IdTrafico { get; set; }
        [Required]
        [Column("RECORD_IDENTIFIER")]
        [StringLength(1)]
        public string RecordIdentifier { get; set; }
        [Column("FILER_ID", TypeName = "numeric(18, 0)")]
        public decimal FilerId { get; set; }
        [Column("COMM_PASSWORD")]
        [StringLength(6)]
        public string CommPassword { get; set; }
        [Required]
        [Column("FILER_ID_TYPE")]
        [StringLength(1)]
        public string FilerIdType { get; set; }
        [Required]
        [Column("APP_IDENTIFIER")]
        [StringLength(2)]
        public string AppIdentifier { get; set; }
        [Column("TRANSMITTER_DATE", TypeName = "datetime")]
        public DateTime TransmitterDate { get; set; }
        [Column("BATCH_CONTROL_NUMBER")]
        [StringLength(6)]
        public string BatchControlNumber { get; set; }
        [Column("DATA_ENTRY")]
        [StringLength(1)]
        public string DataEntry { get; set; }
        [Column("TRANSMITTER_ID", TypeName = "numeric(18, 0)")]
        public decimal? TransmitterId { get; set; }
        [Column("ITN")]
        [StringLength(20)]
        public string Itn { get; set; }
        [Column("XTN")]
        [StringLength(22)]
        public string Xtn { get; set; }
        [Column("TRAILER_ID_NO")]
        [StringLength(15)]
        public string TrailerIdNo { get; set; }

        [InverseProperty("BatchCtlHeaderNavigation")]
        public virtual ShipperBlockControlHeader ShipperBlockControlHeader { get; set; }
    }
}
