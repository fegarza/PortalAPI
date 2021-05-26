using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffg_gfactura_mex")]
    public partial class FfgGfacturaMex
    {
        [Key]
        [Column("id_factura")]
        [StringLength(10)]
        public string IdFactura { get; set; }
        [Column("fecha_factura", TypeName = "datetime")]
        public DateTime FechaFactura { get; set; }
        [Key]
        [Column("tipo_factura")]
        [StringLength(1)]
        public string TipoFactura { get; set; }
        [Required]
        [Column("situacion_factura")]
        [StringLength(1)]
        public string SituacionFactura { get; set; }
        [Column("numero_folio", TypeName = "numeric(12, 0)")]
        public decimal? NumeroFolio { get; set; }
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal? IdRectificacion { get; set; }
        [Required]
        [Column("id_tabulador")]
        [StringLength(3)]
        public string IdTabulador { get; set; }
        [Column("no_fracciones", TypeName = "numeric(3, 0)")]
        public decimal? NoFracciones { get; set; }
        [Column("iva", TypeName = "numeric(12, 2)")]
        public decimal? Iva { get; set; }
        [Column("anticipo", TypeName = "numeric(12, 2)")]
        public decimal? Anticipo { get; set; }
        [Column("saldo", TypeName = "numeric(12, 2)")]
        public decimal? Saldo { get; set; }
        [Column("iva_hon", TypeName = "numeric(12, 2)")]
        public decimal? IvaHon { get; set; }
        [Column("iva_ser", TypeName = "numeric(12, 2)")]
        public decimal? IvaSer { get; set; }
        [Column("total_gts_comp", TypeName = "numeric(12, 2)")]
        public decimal? TotalGtsComp { get; set; }
        [Column("valor_normal", TypeName = "numeric(12, 0)")]
        public decimal? ValorNormal { get; set; }
        [Column("tipo_cambio", TypeName = "numeric(9, 6)")]
        public decimal? TipoCambio { get; set; }
        [Column("base_honorario", TypeName = "numeric(16, 2)")]
        public decimal? BaseHonorario { get; set; }
        [Column("porc_honorario", TypeName = "numeric(7, 4)")]
        public decimal? PorcHonorario { get; set; }
        [Column("total_complemen", TypeName = "numeric(12, 2)")]
        public decimal? TotalComplemen { get; set; }
        [Column("difer_impuesto", TypeName = "numeric(12, 2)")]
        public decimal? DiferImpuesto { get; set; }
        [Column("iva_porcentaje", TypeName = "numeric(5, 2)")]
        public decimal? IvaPorcentaje { get; set; }
        [Column("monto_honorario", TypeName = "numeric(12, 2)")]
        public decimal? MontoHonorario { get; set; }
        [Column("id_cliente_fact")]
        [StringLength(6)]
        public string IdClienteFact { get; set; }
        [Column("nombre_cli_fact")]
        [StringLength(120)]
        public string NombreCliFact { get; set; }
        [Column("rfc_cli_fact")]
        [StringLength(13)]
        public string RfcCliFact { get; set; }
        [Column("domici_cli_fact")]
        [StringLength(80)]
        public string DomiciCliFact { get; set; }
        [Column("colonia_cli_fact")]
        [StringLength(60)]
        public string ColoniaCliFact { get; set; }
        [Column("calle_numero_fact")]
        [StringLength(10)]
        public string CalleNumeroFact { get; set; }
        [Column("ciudad_cli_fact")]
        [StringLength(80)]
        public string CiudadCliFact { get; set; }
        [Column("estado_cli_fact")]
        [StringLength(40)]
        public string EstadoCliFact { get; set; }
        [Column("cp_cli_fact")]
        [StringLength(10)]
        public string CpCliFact { get; set; }
        [Column("poli_anticipo")]
        [StringLength(80)]
        public string PoliAnticipo { get; set; }
        [Column("orden_trans")]
        [StringLength(40)]
        public string OrdenTrans { get; set; }
        [Column("id_corresponsal")]
        [StringLength(6)]
        public string IdCorresponsal { get; set; }
        [Column("id_proveedor")]
        [StringLength(6)]
        public string IdProveedor { get; set; }
        [Column("id_embarque")]
        [StringLength(10)]
        public string IdEmbarque { get; set; }
        [Column("fecha_inicial", TypeName = "datetime")]
        public DateTime? FechaInicial { get; set; }
        [Column("fecha_final", TypeName = "datetime")]
        public DateTime? FechaFinal { get; set; }
        [Column("pedimento")]
        [StringLength(7)]
        public string Pedimento { get; set; }
        [Column("iva_pedimento", TypeName = "numeric(12, 0)")]
        public decimal? IvaPedimento { get; set; }
        [Column("fecha_pedi", TypeName = "datetime")]
        public DateTime? FechaPedi { get; set; }
        [Column("trans_pedi")]
        [StringLength(6)]
        public string TransPedi { get; set; }
        [Column("talon")]
        [StringLength(20)]
        public string Talon { get; set; }
        [Column("imp_exp")]
        [StringLength(1)]
        public string ImpExp { get; set; }
        [Column("aduana")]
        [StringLength(2)]
        public string Aduana { get; set; }
        [Column("seccion")]
        [StringLength(1)]
        public string Seccion { get; set; }
        [Column("regimen")]
        [StringLength(2)]
        public string Regimen { get; set; }
        [Column("patente")]
        [StringLength(4)]
        public string Patente { get; set; }
        [Column("fact_pedi")]
        [StringLength(15)]
        public string FactPedi { get; set; }
        [Column("origen")]
        [StringLength(2)]
        public string Origen { get; set; }
        [Column("marcas")]
        [StringLength(60)]
        public string Marcas { get; set; }
        [Column("numero_mcia")]
        [StringLength(15)]
        public string NumeroMcia { get; set; }
        [Column("descripcion_mcia")]
        [StringLength(250)]
        public string DescripcionMcia { get; set; }
        [Column("peso_mcia", TypeName = "numeric(14, 3)")]
        public decimal? PesoMcia { get; set; }
        [Column("bultos", TypeName = "numeric(8, 0)")]
        public decimal? Bultos { get; set; }
        [Column("id_cliente_pedi")]
        [StringLength(6)]
        public string IdClientePedi { get; set; }
        [Column("nombre_cli_pedi")]
        [StringLength(120)]
        public string NombreCliPedi { get; set; }
        [Column("rfc_cli_pedi")]
        [StringLength(13)]
        public string RfcCliPedi { get; set; }
        [Column("domici_cli_pedi")]
        [StringLength(80)]
        public string DomiciCliPedi { get; set; }
        [Column("colonia_cli_pedi")]
        [StringLength(60)]
        public string ColoniaCliPedi { get; set; }
        [Column("calle_numero_pedi")]
        [StringLength(10)]
        public string CalleNumeroPedi { get; set; }
        [Column("ciudad_cli_pedi")]
        [StringLength(80)]
        public string CiudadCliPedi { get; set; }
        [Column("estado_cli_pedi")]
        [StringLength(40)]
        public string EstadoCliPedi { get; set; }
        [Column("cp_cli_pedi")]
        [StringLength(10)]
        public string CpCliPedi { get; set; }
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
        [Column("observaciones", TypeName = "text")]
        public string Observaciones { get; set; }
        [Column("aduana_razon_social")]
        [StringLength(40)]
        public string AduanaRazonSocial { get; set; }
        [Column("id_agencia_aduanal")]
        [StringLength(4)]
        public string IdAgenciaAduanal { get; set; }
        [Column("factura_enviada")]
        [StringLength(1)]
        public string FacturaEnviada { get; set; }
        [Column("tipo_cambio_ped", TypeName = "numeric(9, 6)")]
        public decimal? TipoCambioPed { get; set; }
        [Column("factor_moneda", TypeName = "numeric(10, 8)")]
        public decimal? FactorMoneda { get; set; }
        [Column("valor_factura", TypeName = "numeric(12, 2)")]
        public decimal? ValorFactura { get; set; }
        [Column("fecha_guia", TypeName = "datetime")]
        public DateTime? FechaGuia { get; set; }
        [Column("tipo_moneda")]
        [StringLength(1)]
        public string TipoMoneda { get; set; }
        [Column("total_gts_cliente", TypeName = "numeric(12, 2)")]
        public decimal? TotalGtsCliente { get; set; }
        [Column("distribuida")]
        [StringLength(1)]
        public string Distribuida { get; set; }
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Column("importe_ret_flete", TypeName = "numeric(12, 2)")]
        public decimal? ImporteRetFlete { get; set; }
        [Column("concepto_retencion")]
        [StringLength(6)]
        public string ConceptoRetencion { get; set; }
        [Column("concepto_monto", TypeName = "numeric(12, 2)")]
        public decimal? ConceptoMonto { get; set; }
        [Column("suma_cajas")]
        public int? SumaCajas { get; set; }
        [Column("prov_razon_social")]
        [StringLength(120)]
        public string ProvRazonSocial { get; set; }
        [Column("linea_razon_social")]
        [StringLength(40)]
        public string LineaRazonSocial { get; set; }
        [Column("destino_embarque")]
        [StringLength(40)]
        public string DestinoEmbarque { get; set; }
        [Column("municipio_embarque")]
        [StringLength(80)]
        public string MunicipioEmbarque { get; set; }
        [Column("cve_flete", TypeName = "decimal(1, 0)")]
        public decimal? CveFlete { get; set; }
        [Column("prov_calle")]
        [StringLength(80)]
        public string ProvCalle { get; set; }
        [Column("prov_numero")]
        [StringLength(10)]
        public string ProvNumero { get; set; }
        [Column("prov_colonia")]
        [StringLength(30)]
        public string ProvColonia { get; set; }
        [Column("prov_cp")]
        [StringLength(8)]
        public string ProvCp { get; set; }
        [Column("suma_camion")]
        public int? SumaCamion { get; set; }
        [Column("prov_id_municipio")]
        [StringLength(4)]
        public string ProvIdMunicipio { get; set; }
        [Column("id_fiscal")]
        [StringLength(18)]
        public string IdFiscal { get; set; }
        [Column("fecha_cancelacion", TypeName = "datetime")]
        public DateTime? FechaCancelacion { get; set; }
        [Column("numproy")]
        [StringLength(20)]
        public string Numproy { get; set; }
        [Column("status_contable", TypeName = "numeric(1, 0)")]
        public decimal? StatusContable { get; set; }
        [Column("poliza_contable", TypeName = "numeric(4, 0)")]
        public decimal? PolizaContable { get; set; }
        [Column("periodo_contable", TypeName = "numeric(6, 0)")]
        public decimal? PeriodoContable { get; set; }
        [Column("movimiento_contable", TypeName = "numeric(6, 0)")]
        public decimal? MovimientoContable { get; set; }
        [Column("observa_fact_prov")]
        [StringLength(255)]
        public string ObservaFactProv { get; set; }
        [Column("fecha_fact_prov", TypeName = "datetime")]
        public DateTime? FechaFactProv { get; set; }
        [Column("fecha_anticipo", TypeName = "datetime")]
        public DateTime? FechaAnticipo { get; set; }
        [Column("fecha_entrada", TypeName = "datetime")]
        public DateTime? FechaEntrada { get; set; }
        [Column("ref_ups")]
        [StringLength(10)]
        public string RefUps { get; set; }
        [Column("id_municipio_fact")]
        [StringLength(4)]
        public string IdMunicipioFact { get; set; }
        [Column("cajas")]
        [StringLength(250)]
        public string Cajas { get; set; }
        [Column("numint_cli_fact")]
        [StringLength(10)]
        public string NumintCliFact { get; set; }
        [Column("total_comisionista", TypeName = "decimal(18, 0)")]
        public decimal? TotalComisionista { get; set; }
        [Column("total_corresponsal", TypeName = "decimal(18, 0)")]
        public decimal? TotalCorresponsal { get; set; }
        [Column("pagado_x_cliente", TypeName = "numeric(18, 0)")]
        public decimal? PagadoXCliente { get; set; }
        [Column("pagado_a_comisionista", TypeName = "numeric(18, 0)")]
        public decimal? PagadoAComisionista { get; set; }
        [Column("pagado_a_corresponsal", TypeName = "numeric(18, 0)")]
        public decimal? PagadoACorresponsal { get; set; }
        [Column("base_comisionista", TypeName = "decimal(18, 0)")]
        public decimal? BaseComisionista { get; set; }
        [Column("base_corresponsal", TypeName = "decimal(18, 0)")]
        public decimal? BaseCorresponsal { get; set; }
        [Column("no_factura_original")]
        [StringLength(10)]
        public string NoFacturaOriginal { get; set; }
        [Column("otros_phcc", TypeName = "numeric(18, 0)")]
        public decimal? OtrosPhcc { get; set; }
        [Column("dta_pedimento", TypeName = "numeric(18, 0)")]
        public decimal? DtaPedimento { get; set; }
        [Column("adval_pedimento", TypeName = "numeric(18, 0)")]
        public decimal? AdvalPedimento { get; set; }
        [Column("iva2_pedimento", TypeName = "numeric(18, 0)")]
        public decimal? Iva2Pedimento { get; set; }
        [Column("otros_pedimento", TypeName = "numeric(18, 0)")]
        public decimal? OtrosPedimento { get; set; }
        [Column("nombre_agente")]
        [StringLength(30)]
        public string NombreAgente { get; set; }
        [Column("ap_paterno_agente")]
        [StringLength(25)]
        public string ApPaternoAgente { get; set; }
        [Column("ap_materno_agente")]
        [StringLength(25)]
        public string ApMaternoAgente { get; set; }
        [Column("registro_agente")]
        [StringLength(4)]
        public string RegistroAgente { get; set; }
        [Column("iva_ser_porcentaje", TypeName = "numeric(5, 0)")]
        public decimal? IvaSerPorcentaje { get; set; }
        [Column("referencia2")]
        [StringLength(30)]
        public string Referencia2 { get; set; }
        [Column("sales_order")]
        [StringLength(100)]
        public string SalesOrder { get; set; }
        [Column("invoice_number")]
        [StringLength(30)]
        public string InvoiceNumber { get; set; }
        [Column("original_invoice")]
        [StringLength(30)]
        public string OriginalInvoice { get; set; }
        [Column("financial_party")]
        [StringLength(30)]
        public string FinancialParty { get; set; }
        [Column("fin_doc_header_id")]
        public int? FinDocHeaderId { get; set; }
        [Column("payment_term_days")]
        [StringLength(30)]
        public string PaymentTermDays { get; set; }
        [Column("due_date", TypeName = "datetime")]
        public DateTime? DueDate { get; set; }
        [Column("pickup_date", TypeName = "datetime")]
        public DateTime? PickupDate { get; set; }
        [Column("delivery_date", TypeName = "datetime")]
        public DateTime? DeliveryDate { get; set; }
        [Column("mode_type")]
        [StringLength(30)]
        public string ModeType { get; set; }
        [Column("trailer_number")]
        [StringLength(30)]
        public string TrailerNumber { get; set; }
        [Column("p_o")]
        [StringLength(200)]
        public string PO { get; set; }
        [Column("total_distance", TypeName = "numeric(5, 0)")]
        public decimal? TotalDistance { get; set; }
        [Column("subtotal", TypeName = "numeric(12, 2)")]
        public decimal? Subtotal { get; set; }
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
        [Column("pac_mensaje_error")]
        [StringLength(50)]
        public string PacMensajeError { get; set; }
        [Column("pac_leyenda_impresa")]
        [StringLength(70)]
        public string PacLeyendaImpresa { get; set; }
        [Column("pac_creditos_restantes")]
        [StringLength(50)]
        public string PacCreditosRestantes { get; set; }
        [Column("pac_version")]
        [StringLength(10)]
        public string PacVersion { get; set; }
        [Column("serie")]
        [StringLength(10)]
        public string Serie { get; set; }
        [Column("no_Aprobacion", TypeName = "numeric(14, 0)")]
        public decimal? NoAprobacion { get; set; }
        [Column("efecto_comp")]
        [StringLength(1)]
        public string EfectoComp { get; set; }
        [Column("sello_digital", TypeName = "text")]
        public string SelloDigital { get; set; }
        [Column("cadena_original", TypeName = "text")]
        public string CadenaOriginal { get; set; }
        [Column("anio_Aprobacion")]
        [StringLength(4)]
        public string AnioAprobacion { get; set; }
        [Column("fact_elect")]
        [StringLength(1)]
        public string FactElect { get; set; }
        [Column("no_certificado")]
        [StringLength(20)]
        public string NoCertificado { get; set; }
        [Column("pac_msg_error2")]
        [StringLength(150)]
        public string PacMsgError2 { get; set; }
        [Column("pac_msg_error3")]
        [StringLength(150)]
        public string PacMsgError3 { get; set; }
        [Column("pac_XML", TypeName = "text")]
        public string PacXml { get; set; }
        [Column("pac_acuse_envio", TypeName = "text")]
        public string PacAcuseEnvio { get; set; }
        [Column("facturas")]
        [StringLength(250)]
        public string Facturas { get; set; }
        [Column("pac_cadena_original")]
        [StringLength(500)]
        public string PacCadenaOriginal { get; set; }
        [Column("pac_cancel_rpt1")]
        [StringLength(100)]
        public string PacCancelRpt1 { get; set; }
        [Column("pac_cancel_rpt2")]
        [StringLength(100)]
        public string PacCancelRpt2 { get; set; }
        [Column("pac_cancel_acuse", TypeName = "text")]
        public string PacCancelAcuse { get; set; }
        [Column("entry_summary")]
        [StringLength(20)]
        public string EntrySummary { get; set; }
        [Column("version")]
        [StringLength(5)]
        public string Version { get; set; }
        [Column("forma_pago")]
        public int? FormaPago { get; set; }
        [Column("metodo_pago")]
        public int? MetodoPago { get; set; }
        [Column("num_cuenta_pago")]
        [StringLength(14)]
        public string NumCuentaPago { get; set; }
        [Column("folio_fiscalorig")]
        [StringLength(15)]
        public string FolioFiscalorig { get; set; }
        [Column("serie_foliofiscalorig")]
        [StringLength(10)]
        public string SerieFoliofiscalorig { get; set; }
        [Column("fecha_foliofiscalorig", TypeName = "datetime")]
        public DateTime? FechaFoliofiscalorig { get; set; }
        [Column("monto_foliofiscalorig", TypeName = "numeric(12, 2)")]
        public decimal? MontoFoliofiscalorig { get; set; }
        [Column("metodo_pago_descripcion")]
        [StringLength(50)]
        public string MetodoPagoDescripcion { get; set; }
        [Column("num_factura")]
        [StringLength(30)]
        public string NumFactura { get; set; }
        [Column("status_pagado_total")]
        [StringLength(1)]
        public string StatusPagadoTotal { get; set; }
        [Column("fecha_aplicacion_pago_total", TypeName = "datetime")]
        public DateTime? FechaAplicacionPagoTotal { get; set; }
        [Column("clave_SAT_metodo_pago")]
        [StringLength(30)]
        public string ClaveSatMetodoPago { get; set; }
        [Column("c_UsoCFDI")]
        [StringLength(5)]
        public string CUsoCfdi { get; set; }
        [Column("c_TipoRelacion")]
        [StringLength(2)]
        public string CTipoRelacion { get; set; }
        [StringLength(1000)]
        public string CondicionesDePago { get; set; }
        [Column("c_claveSATConfirmacion")]
        [StringLength(5)]
        public string CClaveSatconfirmacion { get; set; }
        [StringLength(3)]
        public string ResidenciaFiscal { get; set; }
        [StringLength(40)]
        public string NumRegidTrib { get; set; }
        [Column("id_facturaRelacionada")]
        [StringLength(10)]
        public string IdFacturaRelacionada { get; set; }
        [Column("rc_Relacionada")]
        [StringLength(10)]
        public string RcRelacionada { get; set; }
        [Column("c_FormaPago")]
        [StringLength(3)]
        public string CFormaPago { get; set; }
        [Column("c_MetodoPago")]
        [StringLength(3)]
        public string CMetodoPago { get; set; }
        [Column("c_claveSATTipoCambio")]
        [StringLength(5)]
        public string CClaveSattipoCambio { get; set; }
        [Column("c_claveSATMontoFact")]
        [StringLength(5)]
        public string CClaveSatmontoFact { get; set; }
        [Column("CFDIrelacionados")]
        [StringLength(250)]
        public string Cfdirelacionados { get; set; }
        [Column("cancelado_ws")]
        [StringLength(1)]
        public string CanceladoWs { get; set; }
        [Column(TypeName = "numeric(14, 2)")]
        public decimal? Descuento { get; set; }
        [Column("clave_motivo_cancelacion")]
        [StringLength(3)]
        public string ClaveMotivoCancelacion { get; set; }
    }
}
