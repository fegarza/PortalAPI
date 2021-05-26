using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("cp_det_docto_pago")]
    public partial class CpDetDoctoPago
    {
        [Key]
        [Column("tipo_documento", TypeName = "numeric(3, 0)")]
        public decimal TipoDocumento { get; set; }
        [Column("numproy")]
        [StringLength(20)]
        public string Numproy { get; set; }
        [Key]
        [Column("num_beneficiario", TypeName = "numeric(10, 0)")]
        public decimal NumBeneficiario { get; set; }
        [Key]
        [Column("num_documento", TypeName = "numeric(6, 0)")]
        public decimal NumDocumento { get; set; }
        [Column("saldo_cxp", TypeName = "numeric(16, 4)")]
        public decimal? SaldoCxp { get; set; }
        [Column("valor_cxp", TypeName = "numeric(16, 4)")]
        public decimal? ValorCxp { get; set; }
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Column("fecha_vencimiento", TypeName = "datetime")]
        public DateTime? FechaVencimiento { get; set; }
        [Column("tipo_beneficiario", TypeName = "numeric(3, 0)")]
        public decimal? TipoBeneficiario { get; set; }
        [Column("cve_concepto", TypeName = "numeric(3, 0)")]
        public decimal? CveConcepto { get; set; }
        [Column("status_contable", TypeName = "numeric(1, 0)")]
        public decimal? StatusContable { get; set; }
        [Column("status_cxp", TypeName = "numeric(1, 0)")]
        public decimal StatusCxp { get; set; }
        [Column("fecha_documento", TypeName = "datetime")]
        public DateTime? FechaDocumento { get; set; }
        [Column("fecha_seleccion", TypeName = "datetime")]
        public DateTime? FechaSeleccion { get; set; }
        [Column("usuario")]
        [StringLength(8)]
        public string Usuario { get; set; }
        [Column("grupo")]
        [StringLength(8)]
        public string Grupo { get; set; }
        [Key]
        [Column("num_docto_pago", TypeName = "numeric(10, 0)")]
        public decimal NumDoctoPago { get; set; }
        [Key]
        [Column("num_banco", TypeName = "numeric(2, 0)")]
        public decimal NumBanco { get; set; }
        [Key]
        [Column("num_cuenta")]
        [StringLength(14)]
        public string NumCuenta { get; set; }
        [Column("moneda")]
        [StringLength(5)]
        public string Moneda { get; set; }
        [Key]
        [Column("tipo_comprobante", TypeName = "numeric(1, 0)")]
        public decimal TipoComprobante { get; set; }
        [Column("valor_pago", TypeName = "decimal(16, 4)")]
        public decimal? ValorPago { get; set; }
        [Key]
        [Column("consecutivo")]
        public int Consecutivo { get; set; }
        [Column("poliza_contable", TypeName = "decimal(4, 0)")]
        public decimal? PolizaContable { get; set; }
        [Column("periodo_contable", TypeName = "decimal(6, 0)")]
        public decimal? PeriodoContable { get; set; }
        [Column("movimiento_contable", TypeName = "decimal(6, 0)")]
        public decimal? MovimientoContable { get; set; }
        [Column("num_factura")]
        [StringLength(30)]
        public string NumFactura { get; set; }
        [Column("tipo_cambio", TypeName = "decimal(9, 6)")]
        public decimal? TipoCambio { get; set; }
        [Column("utilidad_cambiaria", TypeName = "decimal(9, 6)")]
        public decimal? UtilidadCambiaria { get; set; }
        [Column("fin_doc_header_id")]
        public int? FinDocHeaderId { get; set; }
        [Column("invoice_number")]
        [StringLength(30)]
        public string InvoiceNumber { get; set; }
        [Column("import_tmsf")]
        public bool? ImportTmsf { get; set; }
    }
}
