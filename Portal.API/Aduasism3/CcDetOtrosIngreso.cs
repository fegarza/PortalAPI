using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("cc_det_otros_ingresos")]
    public partial class CcDetOtrosIngreso
    {
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Key]
        [Column("num_recibo_ingreso", TypeName = "numeric(10, 0)")]
        public decimal NumReciboIngreso { get; set; }
        [Key]
        [Column("tipo_beneficiario", TypeName = "numeric(3, 0)")]
        public decimal TipoBeneficiario { get; set; }
        [Key]
        [Column("cve_beneficiario", TypeName = "numeric(6, 0)")]
        public decimal CveBeneficiario { get; set; }
        [Key]
        [Column("cve_cpto_ingreso", TypeName = "numeric(5, 0)")]
        public decimal CveCptoIngreso { get; set; }
        [Key]
        [Column("id_trafico")]
        [StringLength(10)]
        public string IdTrafico { get; set; }
        [Column("importe", TypeName = "numeric(16, 4)")]
        public decimal? Importe { get; set; }
        [Column("fecha_contable", TypeName = "datetime")]
        public DateTime? FechaContable { get; set; }
        [Column("status_contable", TypeName = "decimal(1, 0)")]
        public decimal? StatusContable { get; set; }
        [Column("id_factura")]
        [StringLength(10)]
        public string IdFactura { get; set; }
        [Column("fecha_captura", TypeName = "datetime")]
        public DateTime? FechaCaptura { get; set; }
        [Column("num_banco", TypeName = "numeric(2, 0)")]
        public decimal? NumBanco { get; set; }
        [Column("num_cuenta")]
        [StringLength(14)]
        public string NumCuenta { get; set; }
        [Column("tipo_cambio", TypeName = "numeric(10, 4)")]
        public decimal? TipoCambio { get; set; }
        [Column("moneda")]
        [StringLength(5)]
        public string Moneda { get; set; }
        [Column("tipo_ref")]
        [StringLength(1)]
        public string TipoRef { get; set; }
        [Column("fecha_factura", TypeName = "datetime")]
        public DateTime? FechaFactura { get; set; }
        [Column("numproy")]
        [StringLength(20)]
        public string Numproy { get; set; }
        [Column("id_rectificacion", TypeName = "decimal(1, 0)")]
        public decimal? IdRectificacion { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime? FechaRegistro { get; set; }
        [Column("poliza_contable", TypeName = "decimal(4, 0)")]
        public decimal? PolizaContable { get; set; }
        [Column("movimiento_contable", TypeName = "decimal(6, 0)")]
        public decimal? MovimientoContable { get; set; }
        [Column("periodo_contable", TypeName = "decimal(6, 0)")]
        public decimal? PeriodoContable { get; set; }
    }
}
