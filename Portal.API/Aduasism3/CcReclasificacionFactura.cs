using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("cc_reclasificacion_facturas")]
    public partial class CcReclasificacionFactura
    {
        [Column("consec_reclasificacion")]
        public int ConsecReclasificacion { get; set; }
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Required]
        [Column("tipo_factura")]
        [StringLength(10)]
        public string TipoFactura { get; set; }
        [Column("id_factura")]
        [StringLength(10)]
        public string IdFactura { get; set; }
        [Column("id_trafico")]
        [StringLength(10)]
        public string IdTrafico { get; set; }
        [Column("num_recibo_ingreso", TypeName = "numeric(10, 0)")]
        public decimal? NumReciboIngreso { get; set; }
        [Column("tipo_beneficiario", TypeName = "numeric(3, 0)")]
        public decimal? TipoBeneficiario { get; set; }
        [Column("cve_beneficiario", TypeName = "numeric(6, 0)")]
        public decimal? CveBeneficiario { get; set; }
        [Column("cve_cpto_ingreso", TypeName = "numeric(5, 0)")]
        public decimal? CveCptoIngreso { get; set; }
        [Column("importe", TypeName = "numeric(16, 4)")]
        public decimal? Importe { get; set; }
        [Column("fecha_contable", TypeName = "datetime")]
        public DateTime? FechaContable { get; set; }
        [Column("status_contable", TypeName = "decimal(1, 0)")]
        public decimal? StatusContable { get; set; }
        [Column("tipo_ref")]
        [StringLength(1)]
        public string TipoRef { get; set; }
        [Column("num_banco", TypeName = "numeric(2, 0)")]
        public decimal? NumBanco { get; set; }
        [Column("tipo_cambio", TypeName = "numeric(10, 4)")]
        public decimal? TipoCambio { get; set; }
        [Column("moneda")]
        [StringLength(5)]
        public string Moneda { get; set; }
        [Column("fecha_captura", TypeName = "datetime")]
        public DateTime? FechaCaptura { get; set; }
        [Column("cliente")]
        [StringLength(20)]
        public string Cliente { get; set; }
        [Column("fecha_factura")]
        [StringLength(10)]
        public string FechaFactura { get; set; }
        [Column("poliza_contable", TypeName = "decimal(4, 0)")]
        public decimal? PolizaContable { get; set; }
        [Column("periodo_contable", TypeName = "decimal(6, 0)")]
        public decimal? PeriodoContable { get; set; }
        [Column("usuario")]
        [StringLength(8)]
        public string Usuario { get; set; }
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Column("movimiento_contable", TypeName = "decimal(5, 0)")]
        public decimal? MovimientoContable { get; set; }
        [Column("monto", TypeName = "numeric(16, 2)")]
        public decimal? Monto { get; set; }
        [Column("consecutivo")]
        public int? Consecutivo { get; set; }
    }
}
