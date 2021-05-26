using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("cp_orden_pago_dcto_sin_factura")]
    public partial class CpOrdenPagoDctoSinFactura
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
        [Column("tipo_cambio", TypeName = "decimal(9, 6)")]
        public decimal? TipoCambio { get; set; }
        [Column("valor_bruto", TypeName = "numeric(16, 4)")]
        public decimal? ValorBruto { get; set; }
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
        public decimal StatusContable { get; set; }
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
        [Key]
        [Column("tipo_beneficiario")]
        public int TipoBeneficiario { get; set; }
        [Column("referencia")]
        [StringLength(255)]
        public string Referencia { get; set; }
        [Column("detalle_sn")]
        public int? DetalleSn { get; set; }
        [Column("ajuste_sn")]
        public int? AjusteSn { get; set; }
        [Column("tipo_ref")]
        [StringLength(1)]
        public string TipoRef { get; set; }
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Column("id_factura")]
        [StringLength(10)]
        public string IdFactura { get; set; }
        [Column("poliza_contable", TypeName = "decimal(4, 0)")]
        public decimal? PolizaContable { get; set; }
        [Column("periodo_contable", TypeName = "decimal(6, 0)")]
        public decimal? PeriodoContable { get; set; }
        [Column("movimiento_contable", TypeName = "decimal(6, 0)")]
        public decimal? MovimientoContable { get; set; }
        [Column("num_factura")]
        [StringLength(30)]
        public string NumFactura { get; set; }
        [Column("id_rectificacion", TypeName = "decimal(1, 0)")]
        public decimal? IdRectificacion { get; set; }
        [Column("valor_pesos", TypeName = "decimal(26, 10)")]
        public decimal? ValorPesos { get; set; }
        [Column("comple_dlls", TypeName = "numeric(27, 10)")]
        public decimal? CompleDlls { get; set; }
        [Column("pedimento")]
        [StringLength(20)]
        public string Pedimento { get; set; }
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Column("seccion")]
        [StringLength(1)]
        public string Seccion { get; set; }
        [Column("aduana_razon_social")]
        [StringLength(40)]
        public string AduanaRazonSocial { get; set; }
        [Column("fin_doc_header_id")]
        public int? FinDocHeaderId { get; set; }
        [Column("invoice_number")]
        [StringLength(30)]
        public string InvoiceNumber { get; set; }
        [Column("existe_provision")]
        [StringLength(1)]
        public string ExisteProvision { get; set; }
        [Column("uuid")]
        [StringLength(36)]
        public string Uuid { get; set; }
        [Column("nombre_xml")]
        [StringLength(100)]
        public string NombreXml { get; set; }
        [Column("guardado_auto_xml")]
        [StringLength(1)]
        public string GuardadoAutoXml { get; set; }
        [Column("ruta_archivo_xml")]
        [StringLength(250)]
        public string RutaArchivoXml { get; set; }
        [Column("fecha_cancel", TypeName = "datetime")]
        public DateTime? FechaCancel { get; set; }
        [Column("nombre_pdf")]
        [StringLength(250)]
        public string NombrePdf { get; set; }
        [Column("clave_pago_gastos")]
        [StringLength(2)]
        public string ClavePagoGastos { get; set; }
        [Column("c_tipo_factor")]
        [StringLength(20)]
        public string CTipoFactor { get; set; }
    }
}
