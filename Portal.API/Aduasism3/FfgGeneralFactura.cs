using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffg_general_factura")]
    public partial class FfgGeneralFactura
    {
        [Column("aduana")]
        [StringLength(50)]
        public string Aduana { get; set; }
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Column("seccion")]
        [StringLength(1)]
        public string Seccion { get; set; }
        [Column("id_patente")]
        [StringLength(4)]
        public string IdPatente { get; set; }
        [Column("prefijo_factura")]
        [StringLength(3)]
        public string PrefijoFactura { get; set; }
        [Column("auto_factura")]
        [StringLength(1)]
        public string AutoFactura { get; set; }
        [Column("prefijo_folio")]
        [StringLength(3)]
        public string PrefijoFolio { get; set; }
        [Column("auto_folio")]
        [StringLength(1)]
        public string AutoFolio { get; set; }
        [Column("prefijo_precuenta")]
        [StringLength(3)]
        public string PrefijoPrecuenta { get; set; }
        [Column("auto_precuenta")]
        [StringLength(1)]
        public string AutoPrecuenta { get; set; }
        [Column("prefijo_relacion")]
        [StringLength(3)]
        public string PrefijoRelacion { get; set; }
        [Column("auto_relacion")]
        [StringLength(1)]
        public string AutoRelacion { get; set; }
        [Column("id_agencia_aduanal")]
        [StringLength(4)]
        public string IdAgenciaAduanal { get; set; }
        [Column("iva_porcentaje", TypeName = "numeric(5, 2)")]
        public decimal? IvaPorcentaje { get; set; }
        [Column("imp_exp")]
        [StringLength(1)]
        public string ImpExp { get; set; }
        [Column("anticipo_automatico")]
        [StringLength(1)]
        public string AnticipoAutomatico { get; set; }
        [Column("pago_automatico")]
        [StringLength(1)]
        public string PagoAutomatico { get; set; }
        [Column("leyenda_factura")]
        [StringLength(1)]
        public string LeyendaFactura { get; set; }
        [Column("leyenda_relacion")]
        [StringLength(1)]
        public string LeyendaRelacion { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime? FechaRegistro { get; set; }
        [Required]
        [Column("id_usuario_registro")]
        [StringLength(6)]
        public string IdUsuarioRegistro { get; set; }
        [Column("fecha_ultmodif", TypeName = "datetime")]
        public DateTime? FechaUltmodif { get; set; }
        [Required]
        [Column("id_usuario_ultmodif")]
        [StringLength(6)]
        public string IdUsuarioUltmodif { get; set; }
        [Column("numero_copias", TypeName = "numeric(5, 0)")]
        public decimal? NumeroCopias { get; set; }
        [Column("reporte_orig")]
        [StringLength(1)]
        public string ReporteOrig { get; set; }
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Column("porc_ret_fletes", TypeName = "numeric(5, 2)")]
        public decimal? PorcRetFletes { get; set; }
        [Column("concepto_retencion")]
        [StringLength(6)]
        public string ConceptoRetencion { get; set; }
        [Column("id_cliente")]
        [StringLength(4)]
        public string IdCliente { get; set; }
        [Column("tipo_cambio_default")]
        [StringLength(1)]
        public string TipoCambioDefault { get; set; }
        [Column("version")]
        [StringLength(100)]
        public string Version { get; set; }
        [Column("fecha_generacion_exe", TypeName = "datetime")]
        public DateTime? FechaGeneracionExe { get; set; }
        [Column("folio_cargo", TypeName = "numeric(5, 0)")]
        public decimal? FolioCargo { get; set; }
        [Column("folio_credito", TypeName = "numeric(5, 0)")]
        public decimal? FolioCredito { get; set; }
        [Column("consecutivo_credito", TypeName = "numeric(5, 0)")]
        public decimal? ConsecutivoCredito { get; set; }
        [Column("consecutivo_cargo", TypeName = "numeric(5, 0)")]
        public decimal? ConsecutivoCargo { get; set; }
        [Column("auto_cargo")]
        [StringLength(1)]
        public string AutoCargo { get; set; }
        [Column("auto_credito")]
        [StringLength(1)]
        public string AutoCredito { get; set; }
        [Column("prefijo_cargo")]
        [StringLength(3)]
        public string PrefijoCargo { get; set; }
        [Column("prefijo_credito")]
        [StringLength(3)]
        public string PrefijoCredito { get; set; }
        [Column("concepto_ame")]
        [StringLength(6)]
        public string ConceptoAme { get; set; }
        [Column("auto_rendicion")]
        [StringLength(1)]
        public string AutoRendicion { get; set; }
        [Column("prefijo_rendicion")]
        [StringLength(3)]
        public string PrefijoRendicion { get; set; }
        [Column("genera_fact_elect")]
        [StringLength(1)]
        public string GeneraFactElect { get; set; }
        [Column("envio_correo")]
        [StringLength(1)]
        public string EnvioCorreo { get; set; }
        [Column("fecha_vencimiento", TypeName = "datetime")]
        public DateTime? FechaVencimiento { get; set; }
        [Column("pac_rfc")]
        [StringLength(13)]
        public string PacRfc { get; set; }
        [Column("pac_cuenta")]
        [StringLength(50)]
        public string PacCuenta { get; set; }
        [Column("pac_pass")]
        [StringLength(50)]
        public string PacPass { get; set; }
        [Column("pac_url_wsdl")]
        [StringLength(100)]
        public string PacUrlWsdl { get; set; }
        [Column("pac_url_wsdl_expuesto")]
        [StringLength(100)]
        public string PacUrlWsdlExpuesto { get; set; }
        [Column("certificado")]
        [StringLength(250)]
        public string Certificado { get; set; }
        [Column("llave_privada")]
        [StringLength(250)]
        public string LlavePrivada { get; set; }
        [Column("contrasena")]
        [StringLength(20)]
        public string Contrasena { get; set; }
        [Column("fecha_vigencia", TypeName = "datetime")]
        public DateTime? FechaVigencia { get; set; }
        [Column("aviso_vigencia", TypeName = "numeric(2, 0)")]
        public decimal? AvisoVigencia { get; set; }
        [Column("rfc")]
        [StringLength(13)]
        public string Rfc { get; set; }
        [Column("rfc_mostrador_nac")]
        [StringLength(13)]
        public string RfcMostradorNac { get; set; }
        [Column("rfc_mostrador_ext")]
        [StringLength(13)]
        public string RfcMostradorExt { get; set; }
        [Column("ruta_xml")]
        [StringLength(250)]
        public string RutaXml { get; set; }
        [Column("ruta_reporte_sat")]
        [StringLength(250)]
        public string RutaReporteSat { get; set; }
        [Column("auto_cotizacion")]
        [StringLength(1)]
        public string AutoCotizacion { get; set; }
        [Column("ruta_archivo_poliza")]
        [StringLength(50)]
        public string RutaArchivoPoliza { get; set; }
        [Column("pac_contrato")]
        [StringLength(1)]
        public string PacContrato { get; set; }
        [Column("auto_ame")]
        [StringLength(1)]
        public string AutoAme { get; set; }
        [Column("criterio_busqueda_ame")]
        [StringLength(1)]
        public string CriterioBusquedaAme { get; set; }
        [Column("auto_orden_pago")]
        [StringLength(1)]
        public string AutoOrdenPago { get; set; }
        [Column("tipo_beneficiario")]
        public int? TipoBeneficiario { get; set; }
        [Column("num_beneficiario", TypeName = "decimal(6, 0)")]
        public decimal? NumBeneficiario { get; set; }
        [Column("tipo_ref")]
        [StringLength(1)]
        public string TipoRef { get; set; }
        [Column("moneda_orpa")]
        [StringLength(3)]
        public string MonedaOrpa { get; set; }
        [Column("cve_concepto_orpa", TypeName = "numeric(3, 0)")]
        public decimal? CveConceptoOrpa { get; set; }
        [Column("ruta_factura_elect")]
        [StringLength(250)]
        public string RutaFacturaElect { get; set; }
        [Column("ruta_reporte_diot")]
        [StringLength(250)]
        public string RutaReporteDiot { get; set; }
        [Column("perfil_cli_correo")]
        [StringLength(20)]
        public string PerfilCliCorreo { get; set; }
        [Column("pac_timbrado_pruebas")]
        [StringLength(1)]
        public string PacTimbradoPruebas { get; set; }
        [Column("tipo_cambio_cta_ame")]
        [StringLength(1)]
        public string TipoCambioCtaAme { get; set; }
        [Column("ruta_rel_archivos_envio_pdf")]
        [StringLength(180)]
        public string RutaRelArchivosEnvioPdf { get; set; }
        [Column("anticipo_seleccion")]
        [StringLength(1)]
        public string AnticipoSeleccion { get; set; }
        [Column("pago_seleccion")]
        [StringLength(1)]
        public string PagoSeleccion { get; set; }
        [Column("concepto_arrendamiento")]
        [StringLength(6)]
        public string ConceptoArrendamiento { get; set; }
        [StringLength(13)]
        public string RfcProvCertif { get; set; }
        [Column("timbres_restantes")]
        public int? TimbresRestantes { get; set; }
        [Column("timbres_aviso")]
        public int? TimbresAviso { get; set; }
    }
}
