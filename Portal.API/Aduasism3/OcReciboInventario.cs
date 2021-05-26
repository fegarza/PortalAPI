using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_recibo_inventario")]
    public partial class OcReciboInventario
    {
        [Key]
        [Column("id_almacen")]
        [StringLength(8)]
        public string IdAlmacen { get; set; }
        [Key]
        [Column("id_recibo")]
        [StringLength(10)]
        public string IdRecibo { get; set; }
        [Column("id_status_inventario")]
        public short IdStatusInventario { get; set; }
        [Column("analyst")]
        [StringLength(100)]
        public string Analyst { get; set; }
        [Column("regimen")]
        public string Regimen { get; set; }
        [Column("incoterm")]
        [StringLength(4)]
        public string Incoterm { get; set; }
        [Column("double_space", TypeName = "decimal(14, 3)")]
        public decimal? DoubleSpace { get; set; }
        [Column("flete", TypeName = "decimal(14, 4)")]
        public decimal? Flete { get; set; }
        [Column("status_flete")]
        public short? StatusFlete { get; set; }
        [Column("solution")]
        [StringLength(250)]
        public string Solution { get; set; }
        [Column("domestic")]
        public bool? Domestic { get; set; }
        [Column("inbond")]
        public bool? Inbond { get; set; }
        [Column("inbond_cancel_date", TypeName = "datetime")]
        public DateTime? InbondCancelDate { get; set; }
        [Column("cooled_material")]
        public bool? CooledMaterial { get; set; }
        [Column("pending_inbond_cancellation")]
        public bool? PendingInbondCancellation { get; set; }
        [Column("pending_to_review")]
        public bool? PendingToReview { get; set; }
        [Column("missing_documents_and_instrucctions")]
        public bool? MissingDocumentsAndInstrucctions { get; set; }
        [Column("ready_to_release")]
        public bool? ReadyToRelease { get; set; }
        [Column("missing_invoice")]
        public bool? MissingInvoice { get; set; }
        [Column("missing_shipper_letter_instructions")]
        public bool? MissingShipperLetterInstructions { get; set; }
        [Column("missing_po")]
        public bool? MissingPo { get; set; }
        [Column("pending_classification")]
        public bool? PendingClassification { get; set; }
        [Column("overage")]
        public bool? Overage { get; set; }
        [Column("shortage")]
        public bool? Shortage { get; set; }
        [Column("numero_vehiculo")]
        [StringLength(20)]
        public string NumeroVehiculo { get; set; }
    }
}
