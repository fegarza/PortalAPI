using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffg_gprecuenta_mex")]
    public partial class FfgGprecuentaMex
    {
        [Key]
        [Column("id_precuenta")]
        [StringLength(10)]
        public string IdPrecuenta { get; set; }
        [Column("fecha_precuenta", TypeName = "datetime")]
        public DateTime? FechaPrecuenta { get; set; }
        [Required]
        [Column("tipo_precuenta")]
        [StringLength(1)]
        public string TipoPrecuenta { get; set; }
        [Required]
        [Column("situacion_precuenta")]
        [StringLength(1)]
        public string SituacionPrecuenta { get; set; }
        [Column("id_factura")]
        [StringLength(10)]
        public string IdFactura { get; set; }
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
        [Column("base_honorario", TypeName = "numeric(12, 2)")]
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
        [Column("id_cliente_prec")]
        [StringLength(6)]
        public string IdClientePrec { get; set; }
        [Column("nombre_cli_prec")]
        [StringLength(120)]
        public string NombreCliPrec { get; set; }
        [Column("rfc_cli_prec")]
        [StringLength(13)]
        public string RfcCliPrec { get; set; }
        [Column("domici_cli_prec")]
        [StringLength(80)]
        public string DomiciCliPrec { get; set; }
        [Column("colonia_cli_prec")]
        [StringLength(60)]
        public string ColoniaCliPrec { get; set; }
        [Column("calle_numero_prec")]
        [StringLength(10)]
        public string CalleNumeroPrec { get; set; }
        [Column("ciudad_cli_prec")]
        [StringLength(80)]
        public string CiudadCliPrec { get; set; }
        [Column("estado_cli_prec")]
        [StringLength(40)]
        public string EstadoCliPrec { get; set; }
        [Column("cp_cli_prec")]
        [StringLength(10)]
        public string CpCliPrec { get; set; }
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
        [Column("num_sellos")]
        public int? NumSellos { get; set; }
        [Column("num_referencias")]
        public int? NumReferencias { get; set; }
        [Column("embar_fraccion", TypeName = "numeric(3, 0)")]
        public decimal? EmbarFraccion { get; set; }
        [Column("id_fiscal")]
        [StringLength(18)]
        public string IdFiscal { get; set; }
        [Column("cve_trans")]
        [StringLength(2)]
        public string CveTrans { get; set; }
        [Column("cant_pedi", TypeName = "numeric(5, 0)")]
        public decimal? CantPedi { get; set; }
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
        [Column("id_municipio_prec")]
        [StringLength(4)]
        public string IdMunicipioPrec { get; set; }
        [Column("cajas")]
        [StringLength(250)]
        public string Cajas { get; set; }
        [Column("tipo_cambio_default")]
        [StringLength(1)]
        public string TipoCambioDefault { get; set; }
        [Column("numint_cli_fact")]
        [StringLength(10)]
        public string NumintCliFact { get; set; }
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
        [Column("color_semaforo")]
        [StringLength(1)]
        public string ColorSemaforo { get; set; }
        [Column("fecha_cruce", TypeName = "datetime")]
        public DateTime? FechaCruce { get; set; }
        [Column("suma_facturas", TypeName = "decimal(10, 0)")]
        public decimal? SumaFacturas { get; set; }
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
        [Column("iva_ser_porcentaje", TypeName = "numeric(5, 2)")]
        public decimal? IvaSerPorcentaje { get; set; }
        [Column("id_factura_ame")]
        [StringLength(10)]
        public string IdFacturaAme { get; set; }
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
        [Column("facturas")]
        [StringLength(250)]
        public string Facturas { get; set; }
        [Column("entry_summary")]
        [StringLength(20)]
        public string EntrySummary { get; set; }
        [Column("tipo_cambio_fact_ame", TypeName = "decimal(9, 6)")]
        public decimal? TipoCambioFactAme { get; set; }
        [Column("saldo_fact_ame", TypeName = "decimal(12, 2)")]
        public decimal? SaldoFactAme { get; set; }
        [Column("atencion")]
        [StringLength(50)]
        public string Atencion { get; set; }
        [Column("entrada_factura_uuid")]
        [StringLength(36)]
        public string EntradaFacturaUuid { get; set; }
        [Column("num_factura")]
        [StringLength(30)]
        public string NumFactura { get; set; }
        [Column("valor_comercial_mn", TypeName = "numeric(12, 0)")]
        public decimal? ValorComercialMn { get; set; }
    }
}
