using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("ffg_reporte_cliente_concepto")]
    public partial class FfgReporteClienteConcepto
    {
        [Column("id_cliente_fact")]
        [StringLength(6)]
        public string IdClienteFact { get; set; }
        [Required]
        [Column("id_factura")]
        [StringLength(10)]
        public string IdFactura { get; set; }
        [Column("imp_exp")]
        [StringLength(1)]
        public string ImpExp { get; set; }
        [Column("fecha_factura", TypeName = "datetime")]
        public DateTime FechaFactura { get; set; }
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal? IdRectificacion { get; set; }
        [Column("monto_honorario", TypeName = "numeric(12, 2)")]
        public decimal? MontoHonorario { get; set; }
        [Column("anticipo", TypeName = "numeric(12, 2)")]
        public decimal? Anticipo { get; set; }
        [Column("saldo", TypeName = "numeric(12, 2)")]
        public decimal? Saldo { get; set; }
        [Column("num_detalle", TypeName = "numeric(4, 0)")]
        public decimal NumDetalle { get; set; }
        [Required]
        [Column("id_concepto")]
        [StringLength(6)]
        public string IdConcepto { get; set; }
        [Column("descripcion")]
        [StringLength(50)]
        public string Descripcion { get; set; }
        [Column("cve_comprobable", TypeName = "numeric(1, 0)")]
        public decimal CveComprobable { get; set; }
        [Column("monto", TypeName = "numeric(12, 2)")]
        public decimal? Monto { get; set; }
    }
}
