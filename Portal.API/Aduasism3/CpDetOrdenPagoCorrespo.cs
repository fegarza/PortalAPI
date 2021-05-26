using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("cp_det_orden_pago_correspo")]
    [Index(nameof(NumDocumento), nameof(Numempresa), nameof(NumBeneficiario), nameof(TipoBeneficiario), Name = "Indx_cp_det_orden_pago_correspo_num_documento_numempresa_num_beneficiario_tipo_beneficiario")]
    public partial class CpDetOrdenPagoCorrespo
    {
        [Key]
        [Column("consecutivo_detalle", TypeName = "numeric(10, 0)")]
        public decimal ConsecutivoDetalle { get; set; }
        [Key]
        [Column("num_documento", TypeName = "numeric(6, 0)")]
        public decimal NumDocumento { get; set; }
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Key]
        [Column("num_beneficiario", TypeName = "numeric(10, 0)")]
        public decimal NumBeneficiario { get; set; }
        [Key]
        [Column("tipo_beneficiario")]
        public int TipoBeneficiario { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime? FechaRegistro { get; set; }
        [Column("referencia")]
        [StringLength(50)]
        public string Referencia { get; set; }
        [Column("id_aduana")]
        [StringLength(3)]
        public string IdAduana { get; set; }
        [Column("pedimento")]
        [StringLength(20)]
        public string Pedimento { get; set; }
        [Column("valor_cxp", TypeName = "numeric(16, 4)")]
        public decimal? ValorCxp { get; set; }
        [Column("id_rectificacion", TypeName = "decimal(1, 0)")]
        public decimal? IdRectificacion { get; set; }
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Column("status_contable", TypeName = "decimal(1, 0)")]
        public decimal? StatusContable { get; set; }
        [Column("fecha_contabilizacion", TypeName = "datetime")]
        public DateTime? FechaContabilizacion { get; set; }
        [Column("poliza_contable", TypeName = "decimal(4, 0)")]
        public decimal? PolizaContable { get; set; }
        [Column("periodo_contable", TypeName = "decimal(6, 0)")]
        public decimal? PeriodoContable { get; set; }
        [Column("movimiento_contable", TypeName = "decimal(6, 0)")]
        public decimal? MovimientoContable { get; set; }
        [Column("cve_concepto", TypeName = "decimal(3, 0)")]
        public decimal? CveConcepto { get; set; }
        [Column("num_factura")]
        [StringLength(30)]
        public string NumFactura { get; set; }
        [Column("saldo_cxp", TypeName = "decimal(13, 0)")]
        public decimal? SaldoCxp { get; set; }
        [Column("por_iva", TypeName = "numeric(5, 2)")]
        public decimal? PorIva { get; set; }
        [Column("importe_iva", TypeName = "numeric(14, 4)")]
        public decimal? ImporteIva { get; set; }
        [Column("importe_retencion_ISR", TypeName = "numeric(14, 4)")]
        public decimal? ImporteRetencionIsr { get; set; }
        [Column("importe_retencion_iva", TypeName = "numeric(14, 4)")]
        public decimal? ImporteRetencionIva { get; set; }
        [Column("numproy")]
        [StringLength(20)]
        public string Numproy { get; set; }
        [Column("num_benef_tercero", TypeName = "numeric(6, 0)")]
        public decimal? NumBenefTercero { get; set; }
        [Column("tipo_benef_tercero")]
        public int? TipoBenefTercero { get; set; }
        [Column("num_factura_tercero")]
        [StringLength(30)]
        public string NumFacturaTercero { get; set; }
        [Column("valor_bruto_tercero", TypeName = "decimal(16, 2)")]
        public decimal? ValorBrutoTercero { get; set; }
        [Column("importe_iva_tercero", TypeName = "decimal(16, 2)")]
        public decimal? ImporteIvaTercero { get; set; }
        [Column("por_iva_tecero", TypeName = "numeric(5, 2)")]
        public decimal? PorIvaTecero { get; set; }
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
        [Column("seccion")]
        [StringLength(1)]
        public string Seccion { get; set; }
        [Column("porcen_comision", TypeName = "decimal(18, 0)")]
        public decimal? PorcenComision { get; set; }
        [Column("porcen_honorario", TypeName = "decimal(18, 0)")]
        public decimal? PorcenHonorario { get; set; }
        [Column("tipo_tabulador")]
        [StringLength(1)]
        public string TipoTabulador { get; set; }
        [Column("uuid_sat")]
        [StringLength(36)]
        public string UuidSat { get; set; }
        [Column("tipo_beneficiario_dos")]
        public int? TipoBeneficiarioDos { get; set; }
        [Column("num_beneficiario_dos", TypeName = "numeric(10, 0)")]
        public decimal? NumBeneficiarioDos { get; set; }
        [Column("rfc_beneficiario_dos")]
        [StringLength(13)]
        public string RfcBeneficiarioDos { get; set; }
        [Column("moneda_tercero")]
        [StringLength(5)]
        public string MonedaTercero { get; set; }
        [Column("tipo_cambio_tercero", TypeName = "decimal(9, 6)")]
        public decimal? TipoCambioTercero { get; set; }
        [Column("retencion_iva_tercero", TypeName = "decimal(14, 4)")]
        public decimal? RetencionIvaTercero { get; set; }
        [Column("c_tipo_factor")]
        [StringLength(20)]
        public string CTipoFactor { get; set; }
    }
}
