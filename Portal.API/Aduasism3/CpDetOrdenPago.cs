using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("cp_det_orden_pago")]
    public partial class CpDetOrdenPago
    {
        [Key]
        [Column("consecutivo_detalle", TypeName = "numeric(10, 0)")]
        public decimal ConsecutivoDetalle { get; set; }
        [Column("cve_concepto", TypeName = "numeric(3, 0)")]
        public decimal CveConcepto { get; set; }
        [Column("numproy")]
        [StringLength(20)]
        public string Numproy { get; set; }
        [Column("valor_bruto", TypeName = "numeric(16, 4)")]
        public decimal? ValorBruto { get; set; }
        [Column("valor_descuento", TypeName = "numeric(16, 4)")]
        public decimal? ValorDescuento { get; set; }
        [Key]
        [Column("num_documento", TypeName = "numeric(6, 0)")]
        public decimal NumDocumento { get; set; }
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Key]
        [Column("num_beneficiario", TypeName = "numeric(10, 0)")]
        public decimal NumBeneficiario { get; set; }
        [Column("importe_iva", TypeName = "numeric(14, 4)")]
        public decimal? ImporteIva { get; set; }
        [Column("importe_retencion", TypeName = "numeric(14, 4)")]
        public decimal? ImporteRetencion { get; set; }
        [Column("valor_cxp", TypeName = "numeric(16, 4)")]
        public decimal? ValorCxp { get; set; }
        [Column("por_retencion", TypeName = "numeric(5, 2)")]
        public decimal? PorRetencion { get; set; }
        [Column("por_iva", TypeName = "numeric(5, 2)")]
        public decimal? PorIva { get; set; }
        [Key]
        [Column("tipo_beneficiario")]
        public int TipoBeneficiario { get; set; }
        [Column("status_contable", TypeName = "numeric(1, 0)")]
        public decimal? StatusContable { get; set; }
        [Column("fecha_contabilizacion", TypeName = "datetime")]
        public DateTime? FechaContabilizacion { get; set; }
        [Column("tipo_ref")]
        [StringLength(1)]
        public string TipoRef { get; set; }
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Column("poliza_contable", TypeName = "decimal(4, 0)")]
        public decimal? PolizaContable { get; set; }
        [Column("periodo_contable", TypeName = "decimal(6, 0)")]
        public decimal? PeriodoContable { get; set; }
        [Column("movimiento_contable", TypeName = "decimal(6, 0)")]
        public decimal? MovimientoContable { get; set; }
        [Column("usuario")]
        [StringLength(8)]
        public string Usuario { get; set; }
        [Column("grupo")]
        [StringLength(8)]
        public string Grupo { get; set; }
        [Column("tipo_beneficiario_dos")]
        public int? TipoBeneficiarioDos { get; set; }
        [Column("num_beneficiario_dos", TypeName = "numeric(10, 0)")]
        public decimal? NumBeneficiarioDos { get; set; }
        [Column("cantidad", TypeName = "numeric(5, 0)")]
        public decimal? Cantidad { get; set; }
        [Column("numempresa_origen")]
        public int? NumempresaOrigen { get; set; }
        [Column("fin_doc_header_id")]
        public int? FinDocHeaderId { get; set; }
        [Column("invoice_number")]
        [StringLength(30)]
        public string InvoiceNumber { get; set; }
        [Column("id_factura")]
        [StringLength(10)]
        public string IdFactura { get; set; }
        [Column("num_factura")]
        [StringLength(30)]
        public string NumFactura { get; set; }
        [Column("id_rectificacion", TypeName = "decimal(1, 0)")]
        public decimal? IdRectificacion { get; set; }
        [Column("monto_cobrado", TypeName = "numeric(12, 2)")]
        public decimal? MontoCobrado { get; set; }
        [Column("observaciones")]
        [StringLength(255)]
        public string Observaciones { get; set; }
        [Column("uuid")]
        [StringLength(36)]
        public string Uuid { get; set; }
        [Column("nombre_xml")]
        [StringLength(50)]
        public string NombreXml { get; set; }
        [Column("guardado_auto_xml")]
        [StringLength(1)]
        public string GuardadoAutoXml { get; set; }
        [Column("ruta_archivo_xml")]
        [StringLength(250)]
        public string RutaArchivoXml { get; set; }
        [Column("clave_pago_gastos")]
        [StringLength(2)]
        public string ClavePagoGastos { get; set; }
        [Column("c_tipo_factor")]
        [StringLength(20)]
        public string CTipoFactor { get; set; }
    }
}
