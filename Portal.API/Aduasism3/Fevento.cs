using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("feventos")]
    public partial class Fevento
    {
        [Key]
        [Column("id_entrada")]
        [StringLength(10)]
        public string IdEntrada { get; set; }
        [Column("id_trafico")]
        [StringLength(10)]
        public string IdTrafico { get; set; }
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Column("yard_in", TypeName = "datetime")]
        public DateTime? YardIn { get; set; }
        [Column("freight_arrived", TypeName = "datetime")]
        public DateTime? FreightArrived { get; set; }
        [Column("previo_started", TypeName = "datetime")]
        public DateTime? PrevioStarted { get; set; }
        [Column("previo_completed", TypeName = "datetime")]
        public DateTime? PrevioCompleted { get; set; }
        [Column("documents_received", TypeName = "datetime")]
        public DateTime? DocumentsReceived { get; set; }
        [Column("classified", TypeName = "datetime")]
        public DateTime? Classified { get; set; }
        [Column("embarque_ready", TypeName = "datetime")]
        public DateTime? EmbarqueReady { get; set; }
        [Column("work_order_ready", TypeName = "datetime")]
        public DateTime? WorkOrderReady { get; set; }
        [Column("funds_requested", TypeName = "datetime")]
        public DateTime? FundsRequested { get; set; }
        [Column("funds_received", TypeName = "datetime")]
        public DateTime? FundsReceived { get; set; }
        [Column("pedimento_validated", TypeName = "datetime")]
        public DateTime? PedimentoValidated { get; set; }
        [Column("pedimento_paid", TypeName = "datetime")]
        public DateTime? PedimentoPaid { get; set; }
        [Column("incomplete_documentation", TypeName = "datetime")]
        public DateTime? IncompleteDocumentation { get; set; }
        [Column("loaded", TypeName = "datetime")]
        public DateTime? Loaded { get; set; }
        [Column("yard_out", TypeName = "datetime")]
        public DateTime? YardOut { get; set; }
        [Column("exam1", TypeName = "datetime")]
        public DateTime? Exam1 { get; set; }
        [Column("exam2", TypeName = "datetime")]
        public DateTime? Exam2 { get; set; }
        [Column("release", TypeName = "datetime")]
        public DateTime? Release { get; set; }
        [Column("trans_mex_carrier", TypeName = "datetime")]
        public DateTime? TransMexCarrier { get; set; }
        [Column("invoiced", TypeName = "datetime")]
        public DateTime? Invoiced { get; set; }
        [Column("id_embarque")]
        [StringLength(10)]
        public string IdEmbarque { get; set; }
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Column("factura_classified", TypeName = "datetime")]
        public DateTime? FacturaClassified { get; set; }
        [Column("entrada_classified", TypeName = "datetime")]
        public DateTime? EntradaClassified { get; set; }
        [Column("ready_to_file", TypeName = "datetime")]
        public DateTime? ReadyToFile { get; set; }
        [Column("delivery_order_printed", TypeName = "datetime")]
        public DateTime? DeliveryOrderPrinted { get; set; }
    }
}
