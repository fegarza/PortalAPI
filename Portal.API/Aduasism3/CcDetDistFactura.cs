using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("cc_det_dist_factura")]
    public partial class CcDetDistFactura
    {
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Key]
        [Column("num_recibo_ingreso", TypeName = "numeric(6, 0)")]
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
        [Column("id_factura")]
        [StringLength(10)]
        public string IdFactura { get; set; }
        [Column("importe", TypeName = "numeric(16, 4)")]
        public decimal? Importe { get; set; }
        [Column("fecha_contable", TypeName = "datetime")]
        public DateTime? FechaContable { get; set; }
        [Column("status_contable", TypeName = "decimal(1, 0)")]
        public decimal? StatusContable { get; set; }
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
        [Key]
        [Column("tipo_factura")]
        [StringLength(10)]
        public string TipoFactura { get; set; }
        [Column("fecha_factura", TypeName = "datetime")]
        public DateTime? FechaFactura { get; set; }
        [Column("numproy")]
        [StringLength(20)]
        public string Numproy { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime? FechaRegistro { get; set; }
        [Column("tipo_cambio_factura", TypeName = "decimal(10, 4)")]
        public decimal? TipoCambioFactura { get; set; }
        [Column("poliza_contable", TypeName = "decimal(5, 0)")]
        public decimal? PolizaContable { get; set; }
        [Column("periodo_contable", TypeName = "decimal(6, 0)")]
        public decimal? PeriodoContable { get; set; }
        [Column("movimiento_contable", TypeName = "decimal(6, 0)")]
        public decimal? MovimientoContable { get; set; }
        [Column("consecutivo")]
        public int? Consecutivo { get; set; }
        [Column("invoice_number")]
        [StringLength(30)]
        public string InvoiceNumber { get; set; }
        [Column("fin_doc_header_id")]
        public int? FinDocHeaderId { get; set; }
        [Column("num_parcialidad")]
        public int? NumParcialidad { get; set; }
        [Column("status_timbre")]
        [StringLength(1)]
        public string StatusTimbre { get; set; }
        [Column("pac_uuid")]
        [StringLength(36)]
        public string PacUuid { get; set; }
        [Column("pac_fecha_timbrado", TypeName = "datetime")]
        public DateTime? PacFechaTimbrado { get; set; }
        [Column("pac_no_certificado_sat")]
        [StringLength(20)]
        public string PacNoCertificadoSat { get; set; }
        [Column("pac_sello_sat", TypeName = "text")]
        public string PacSelloSat { get; set; }
        [Column("pac_XML", TypeName = "text")]
        public string PacXml { get; set; }
        [Column("pac_cadena_original")]
        [StringLength(500)]
        public string PacCadenaOriginal { get; set; }
        [Column("pac_version")]
        [StringLength(3)]
        public string PacVersion { get; set; }
        [Column("no_certificado")]
        [StringLength(20)]
        public string NoCertificado { get; set; }
        [Column("sello_digital", TypeName = "text")]
        public string SelloDigital { get; set; }
        [Column(TypeName = "decimal(16, 2)")]
        public decimal? ImpSaldoAnt { get; set; }
        [Column(TypeName = "decimal(16, 2)")]
        public decimal? ImpPagado { get; set; }
        [Column(TypeName = "decimal(16, 2)")]
        public decimal? ImpSaldoInsoluto { get; set; }
        [Column("pac_mensaje_error")]
        [StringLength(50)]
        public string PacMensajeError { get; set; }
        [Column("pac_msg_error2")]
        [StringLength(150)]
        public string PacMsgError2 { get; set; }
        [Column("pac_msg_error3")]
        [StringLength(150)]
        public string PacMsgError3 { get; set; }
        [Column("folio", TypeName = "numeric(12, 0)")]
        public decimal? Folio { get; set; }
        [Column("ImpPHCCAnt", TypeName = "decimal(16, 2)")]
        public decimal? ImpPhccant { get; set; }
        [Column("ImpPHCCPagado", TypeName = "decimal(16, 2)")]
        public decimal? ImpPhccpagado { get; set; }
        [Column("ImpPHCCInsoluto", TypeName = "decimal(16, 2)")]
        public decimal? ImpPhccinsoluto { get; set; }
    }
}
