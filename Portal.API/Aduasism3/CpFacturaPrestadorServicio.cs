using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("cp_factura_prestador_servicios")]
    public partial class CpFacturaPrestadorServicio
    {
        [Key]
        [Column("num_documento", TypeName = "numeric(6, 0)")]
        public decimal NumDocumento { get; set; }
        [Column("fecha_documento", TypeName = "datetime")]
        public DateTime FechaDocumento { get; set; }
        [Column("fecha_contabilizacion", TypeName = "datetime")]
        public DateTime FechaContabilizacion { get; set; }
        [Column("fecha_recepcion", TypeName = "datetime")]
        public DateTime FechaRecepcion { get; set; }
        [Required]
        [Column("numproy")]
        [StringLength(20)]
        public string Numproy { get; set; }
        [Key]
        [Column("num_beneficiario", TypeName = "numeric(6, 0)")]
        public decimal NumBeneficiario { get; set; }
        [Column("cve_concepto", TypeName = "numeric(3, 0)")]
        public decimal CveConcepto { get; set; }
        [Column("fecha_vencimiento", TypeName = "datetime")]
        public DateTime FechaVencimiento { get; set; }
        [Required]
        [Column("moneda")]
        [StringLength(5)]
        public string Moneda { get; set; }
        [Column("tipo_cambio", TypeName = "numeric(9, 2)")]
        public decimal? TipoCambio { get; set; }
        [Column("valor_bruto", TypeName = "numeric(16, 4)")]
        public decimal ValorBruto { get; set; }
        [Column("valor_descuento", TypeName = "numeric(16, 4)")]
        public decimal? ValorDescuento { get; set; }
        [Column("valor_cxp", TypeName = "numeric(16, 4)")]
        public decimal? ValorCxp { get; set; }
        [Column("importe_iva", TypeName = "numeric(14, 4)")]
        public decimal? ImporteIva { get; set; }
        [Column("importe_retencion", TypeName = "numeric(14, 4)")]
        public decimal? ImporteRetencion { get; set; }
        [Column("por_iva", TypeName = "numeric(5, 2)")]
        public decimal? PorIva { get; set; }
        [Column("por_retencion", TypeName = "numeric(5, 2)")]
        public decimal? PorRetencion { get; set; }
        [Column("saldo_cxp", TypeName = "numeric(13, 2)")]
        public decimal? SaldoCxp { get; set; }
        [Column("num_docto_pago", TypeName = "numeric(10, 0)")]
        public decimal? NumDoctoPago { get; set; }
        [Column("forma_pago", TypeName = "numeric(1, 0)")]
        public decimal? FormaPago { get; set; }
        [Column("fecha_pago", TypeName = "datetime")]
        public DateTime? FechaPago { get; set; }
        [Column("num_cuenta")]
        [StringLength(14)]
        public string NumCuenta { get; set; }
        [Column("num_banco", TypeName = "numeric(2, 0)")]
        public decimal? NumBanco { get; set; }
        [Column("status_contable", TypeName = "numeric(1, 0)")]
        public decimal? StatusContable { get; set; }
        [Column("status_cxp", TypeName = "decimal(1, 0)")]
        public decimal? StatusCxp { get; set; }
        [Column("fecha_captura", TypeName = "datetime")]
        public DateTime FechaCaptura { get; set; }
        [Column("usuario")]
        [StringLength(8)]
        public string Usuario { get; set; }
        [Column("grupo")]
        [StringLength(8)]
        public string Grupo { get; set; }
        [Column("valor_cxp_ajuste", TypeName = "numeric(16, 4)")]
        public decimal? ValorCxpAjuste { get; set; }
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Column("tipo_documento", TypeName = "numeric(3, 0)")]
        public decimal? TipoDocumento { get; set; }
        [Column("importe_iva_ajuste", TypeName = "decimal(14, 4)")]
        public decimal? ImporteIvaAjuste { get; set; }
        [Column("importe_retencion_ajuste", TypeName = "decimal(14, 4)")]
        public decimal? ImporteRetencionAjuste { get; set; }
        [Column("valor_bruto_ajuste", TypeName = "decimal(16, 4)")]
        public decimal? ValorBrutoAjuste { get; set; }
        [Column("tipo_beneficiario")]
        public int? TipoBeneficiario { get; set; }
        [Column("num_factura")]
        [StringLength(30)]
        public string NumFactura { get; set; }
    }
}
