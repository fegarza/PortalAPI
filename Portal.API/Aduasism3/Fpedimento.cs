using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fpedimento")]
    [Index(nameof(IdCliente), Name = "Indx_fpedimento_id_cliente")]
    [Index(nameof(IdPatente), nameof(Pedimento), nameof(IdAduana), Name = "Indx_fpedimento_id_patente_pedimento_id_aduana")]
    [Index(nameof(IdPatente), nameof(Pedimento), nameof(IdAduana), nameof(Seccion), Name = "Indx_fpedimento_id_patente_pedimento_id_aduana_seccion")]
    [Index(nameof(IdTipoPedimento), nameof(IdPatente), nameof(IdAduana), nameof(Seccion), Name = "Indx_fpedimento_id_pedimento_id_patente_id_aduana_seccion")]
    [Index(nameof(Rowguid), Name = "index_487724840", IsUnique = true)]
    public partial class Fpedimento
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "decimal(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Required]
        [Column("id_tipo_pedimento")]
        [StringLength(2)]
        public string IdTipoPedimento { get; set; }
        [Required]
        [Column("id_patente")]
        [StringLength(4)]
        public string IdPatente { get; set; }
        [Column("pedimento")]
        [StringLength(7)]
        public string Pedimento { get; set; }
        [Required]
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Required]
        [Column("seccion")]
        [StringLength(1)]
        public string Seccion { get; set; }
        [Column("id_patente_transito")]
        [StringLength(4)]
        public string IdPatenteTransito { get; set; }
        [Column("pedimento_transito")]
        [StringLength(7)]
        public string PedimentoTransito { get; set; }
        [Column("id_aduana_transito")]
        [StringLength(2)]
        public string IdAduanaTransito { get; set; }
        [Column("seccion_transito")]
        [StringLength(1)]
        public string SeccionTransito { get; set; }
        [Required]
        [Column("cve_tipo_operacion")]
        [StringLength(1)]
        public string CveTipoOperacion { get; set; }
        [Required]
        [Column("id_regimen")]
        [StringLength(2)]
        public string IdRegimen { get; set; }
        [Required]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Required]
        [Column("razon_social_cliente")]
        [StringLength(120)]
        public string RazonSocialCliente { get; set; }
        [Required]
        [Column("rfc_cliente")]
        [StringLength(13)]
        public string RfcCliente { get; set; }
        [Required]
        [Column("calle_cliente")]
        [StringLength(80)]
        public string CalleCliente { get; set; }
        [Required]
        [Column("numero_cliente")]
        [StringLength(10)]
        public string NumeroCliente { get; set; }
        [Required]
        [Column("id_municipio")]
        [StringLength(4)]
        public string IdMunicipio { get; set; }
        [Required]
        [Column("municipio_cliente")]
        [StringLength(80)]
        public string MunicipioCliente { get; set; }
        [Column("estado")]
        [StringLength(40)]
        public string Estado { get; set; }
        [Required]
        [Column("cp_cliente")]
        [StringLength(10)]
        public string CpCliente { get; set; }
        [Required]
        [Column("cve_destino")]
        [StringLength(1)]
        public string CveDestino { get; set; }
        [Required]
        [Column("cve_transporte")]
        [StringLength(2)]
        public string CveTransporte { get; set; }
        [Column("cve_terceros")]
        [StringLength(1)]
        public string CveTerceros { get; set; }
        [Column("plazo", TypeName = "decimal(3, 0)")]
        public decimal? Plazo { get; set; }
        [Column("id_almacen_fiscal")]
        [StringLength(4)]
        public string IdAlmacenFiscal { get; set; }
        [Column("descripcion_alm_fiscal")]
        [StringLength(250)]
        public string DescripcionAlmFiscal { get; set; }
        [Required]
        [Column("id_pais_origen")]
        [StringLength(3)]
        public string IdPaisOrigen { get; set; }
        [Required]
        [Column("id_pais_vendedor")]
        [StringLength(3)]
        public string IdPaisVendedor { get; set; }
        [Required]
        [Column("cve_calculo_dta")]
        [StringLength(1)]
        public string CveCalculoDta { get; set; }
        [Column("al_millar", TypeName = "decimal(4, 2)")]
        public decimal? AlMillar { get; set; }
        [Column("cuota_fija", TypeName = "decimal(12, 0)")]
        public decimal? CuotaFija { get; set; }
        [Column("dta_porcentaje", TypeName = "decimal(5, 2)")]
        public decimal DtaPorcentaje { get; set; }
        [Required]
        [Column("dta_fp1")]
        [StringLength(2)]
        public string DtaFp1 { get; set; }
        [Column("dta_fp2")]
        [StringLength(2)]
        public string DtaFp2 { get; set; }
        [Column("dta_importe1", TypeName = "decimal(12, 0)")]
        public decimal? DtaImporte1 { get; set; }
        [Column("dta_importe2", TypeName = "decimal(12, 0)")]
        public decimal? DtaImporte2 { get; set; }
        [Column("valor_factura", TypeName = "decimal(12, 2)")]
        public decimal ValorFactura { get; set; }
        [Column("valor_comercial", TypeName = "decimal(12, 2)")]
        public decimal ValorComercial { get; set; }
        [Column("factor_moneda", TypeName = "decimal(10, 8)")]
        public decimal FactorMoneda { get; set; }
        [Column("factor_actualizacion", TypeName = "decimal(10, 8)")]
        public decimal FactorActualizacion { get; set; }
        [Column("factor_ajuste", TypeName = "numeric(13, 9)")]
        public decimal FactorAjuste { get; set; }
        [Column("fecha_pago", TypeName = "datetime")]
        public DateTime FechaPago { get; set; }
        [Column("fecha_entrada", TypeName = "datetime")]
        public DateTime FechaEntrada { get; set; }
        [Column("tipo_cambio", TypeName = "decimal(9, 6)")]
        public decimal TipoCambio { get; set; }
        [Column("fletes_incrementa", TypeName = "decimal(12, 2)")]
        public decimal? FletesIncrementa { get; set; }
        [Column("seguros_incrementa", TypeName = "decimal(12, 2)")]
        public decimal? SegurosIncrementa { get; set; }
        [Column("gastos_incrementa_me", TypeName = "decimal(12, 2)")]
        public decimal? GastosIncrementaMe { get; set; }
        [Column("gastos_incrementa_dls", TypeName = "decimal(12, 2)")]
        public decimal? GastosIncrementaDls { get; set; }
        [Column("flete_no_incrementa", TypeName = "decimal(12, 2)")]
        public decimal? FleteNoIncrementa { get; set; }
        [Column("seguro_no_incrementa", TypeName = "decimal(12, 2)")]
        public decimal? SeguroNoIncrementa { get; set; }
        [Column("peso_kgs", TypeName = "decimal(14, 3)")]
        public decimal PesoKgs { get; set; }
        [Column("recargo_porcentaje", TypeName = "decimal(10, 5)")]
        public decimal? RecargoPorcentaje { get; set; }
        [Column("recargo_forma_pago")]
        [StringLength(2)]
        public string RecargoFormaPago { get; set; }
        [Column("recargo_importe", TypeName = "decimal(12, 0)")]
        public decimal? RecargoImporte { get; set; }
        [Column("observaciones")]
        [StringLength(250)]
        public string Observaciones { get; set; }
        [Column("anexo", TypeName = "text")]
        public string Anexo { get; set; }
        [Column("id_apoderado")]
        [StringLength(6)]
        public string IdApoderado { get; set; }
        [Column("apoderado")]
        [StringLength(50)]
        public string Apoderado { get; set; }
        [Column("rfc_apoderado")]
        [StringLength(13)]
        public string RfcApoderado { get; set; }
        [Column("firma_shcp")]
        [StringLength(8)]
        public string FirmaShcp { get; set; }
        [Column("firma_banco")]
        [StringLength(10)]
        public string FirmaBanco { get; set; }
        [Column("id_banco")]
        [StringLength(2)]
        public string IdBanco { get; set; }
        [Column("opn_banco")]
        [StringLength(10)]
        public string OpnBanco { get; set; }
        [Column("caja_banco")]
        [StringLength(3)]
        public string CajaBanco { get; set; }
        [Column("importe_efectivo", TypeName = "decimal(12, 0)")]
        public decimal? ImporteEfectivo { get; set; }
        [Column("importe_otros", TypeName = "decimal(12, 0)")]
        public decimal? ImporteOtros { get; set; }
        [Column("fecha_pago_banco", TypeName = "datetime")]
        public DateTime? FechaPagoBanco { get; set; }
        [Required]
        [Column("id_usuario")]
        [StringLength(6)]
        public string IdUsuario { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime FechaRegistro { get; set; }
        [Required]
        [Column("id_usuario_ult_modif")]
        [StringLength(6)]
        public string IdUsuarioUltModif { get; set; }
        [Column("fecha_ult_modif", TypeName = "datetime")]
        public DateTime FechaUltModif { get; set; }
        [Column("iva_forma_pago1")]
        [StringLength(2)]
        public string IvaFormaPago1 { get; set; }
        [Column("iva_forma_pago2")]
        [StringLength(2)]
        public string IvaFormaPago2 { get; set; }
        [Column("iva_importe1", TypeName = "decimal(12, 0)")]
        public decimal? IvaImporte1 { get; set; }
        [Column("iva_importe2", TypeName = "decimal(12, 0)")]
        public decimal? IvaImporte2 { get; set; }
        [Column("advalorem_forma_pago1")]
        [StringLength(2)]
        public string AdvaloremFormaPago1 { get; set; }
        [Column("advalorem_forma_pago2")]
        [StringLength(2)]
        public string AdvaloremFormaPago2 { get; set; }
        [Column("advalorem_importe1", TypeName = "decimal(12, 0)")]
        public decimal? AdvaloremImporte1 { get; set; }
        [Column("advalorem_importe2", TypeName = "decimal(12, 0)")]
        public decimal? AdvaloremImporte2 { get; set; }
        [Column("isan_forma_pago")]
        [StringLength(2)]
        public string IsanFormaPago { get; set; }
        [Column("isan_importe", TypeName = "decimal(12, 0)")]
        public decimal? IsanImporte { get; set; }
        [Column("ieps_forma_pago")]
        [StringLength(2)]
        public string IepsFormaPago { get; set; }
        [Column("ieps_importe", TypeName = "decimal(12, 0)")]
        public decimal? IepsImporte { get; set; }
        [Column("cuota_comp_forma_pago1")]
        [StringLength(2)]
        public string CuotaCompFormaPago1 { get; set; }
        [Column("cuota_comp_forma_pago2")]
        [StringLength(2)]
        public string CuotaCompFormaPago2 { get; set; }
        [Column("cuota_comp_importe1", TypeName = "decimal(12, 0)")]
        public decimal? CuotaCompImporte1 { get; set; }
        [Column("cuota_comp_importe2", TypeName = "decimal(12, 0)")]
        public decimal? CuotaCompImporte2 { get; set; }
        [Column("importe_banco", TypeName = "decimal(12, 0)")]
        public decimal? ImporteBanco { get; set; }
        [Column("valor_comercial_mn", TypeName = "decimal(12, 0)")]
        public decimal? ValorComercialMn { get; set; }
        [Column("valor_aduana", TypeName = "decimal(12, 0)")]
        public decimal? ValorAduana { get; set; }
        [Column("incrementable", TypeName = "decimal(12, 0)")]
        public decimal? Incrementable { get; set; }
        [Column("fletes_importe", TypeName = "decimal(12, 0)")]
        public decimal? FletesImporte { get; set; }
        [Column("seguros_importe", TypeName = "decimal(12, 0)")]
        public decimal? SegurosImporte { get; set; }
        [Column("gastos_me_importe", TypeName = "decimal(12, 0)")]
        public decimal? GastosMeImporte { get; set; }
        [Column("gastos_dls_importe", TypeName = "decimal(12, 0)")]
        public decimal? GastosDlsImporte { get; set; }
        [Column("flete_no_importe", TypeName = "decimal(12, 0)")]
        public decimal? FleteNoImporte { get; set; }
        [Column("seguro_no_importe", TypeName = "decimal(12, 0)")]
        public decimal? SeguroNoImporte { get; set; }
        [Column("recargo_porcentaje_pago", TypeName = "decimal(10, 5)")]
        public decimal? RecargoPorcentajePago { get; set; }
        [Column("recargo_equivalente", TypeName = "decimal(12, 0)")]
        public decimal? RecargoEquivalente { get; set; }
        [Column("recargo_equivalente_fp")]
        [StringLength(2)]
        public string RecargoEquivalenteFp { get; set; }
        [Column("id_moneda_comercial")]
        [StringLength(4)]
        public string IdMonedaComercial { get; set; }
        [Column("id_moneda_flete")]
        [StringLength(4)]
        public string IdMonedaFlete { get; set; }
        [Column("factor_flete", TypeName = "decimal(10, 8)")]
        public decimal? FactorFlete { get; set; }
        [Column("id_moneda_seguro")]
        [StringLength(4)]
        public string IdMonedaSeguro { get; set; }
        [Column("factor_seguro", TypeName = "decimal(10, 8)")]
        public decimal? FactorSeguro { get; set; }
        [Column("id_moneda_otros")]
        [StringLength(4)]
        public string IdMonedaOtros { get; set; }
        [Column("factor_otros", TypeName = "decimal(10, 8)")]
        public decimal? FactorOtros { get; set; }
        [Column("id_moneda_frontera")]
        [StringLength(4)]
        public string IdMonedaFrontera { get; set; }
        [Column("factor_frontera", TypeName = "decimal(10, 8)")]
        public decimal? FactorFrontera { get; set; }
        [Column("id_moneda_flete_ni")]
        [StringLength(4)]
        public string IdMonedaFleteNi { get; set; }
        [Column("factor_flete_ni", TypeName = "decimal(10, 8)")]
        public decimal? FactorFleteNi { get; set; }
        [Column("id_moneda_seguro_ni")]
        [StringLength(4)]
        public string IdMonedaSeguroNi { get; set; }
        [Column("factor_seguro_ni", TypeName = "decimal(10, 8)")]
        public decimal? FactorSeguroNi { get; set; }
        [Column("colonia_cliente")]
        [StringLength(60)]
        public string ColoniaCliente { get; set; }
        [Column("rectificacion_extemporanea")]
        [StringLength(1)]
        public string RectificacionExtemporanea { get; set; }
        [Column("tipo_movimiento", TypeName = "decimal(2, 0)")]
        public decimal? TipoMovimiento { get; set; }
        [Column("cve_regimen")]
        [StringLength(3)]
        public string CveRegimen { get; set; }
        [Column("curp_imp")]
        [StringLength(18)]
        public string CurpImp { get; set; }
        [Column("curp_ag_ad")]
        [StringLength(18)]
        public string CurpAgAd { get; set; }
        [Column("curp_apoderado")]
        [StringLength(18)]
        public string CurpApoderado { get; set; }
        [Column("medio_trans_salida")]
        [StringLength(2)]
        public string MedioTransSalida { get; set; }
        [Column("medio_trans_arribo")]
        [StringLength(2)]
        public string MedioTransArribo { get; set; }
        [Column("numero_interior")]
        [StringLength(10)]
        public string NumeroInterior { get; set; }
        [Column("entidad_federativa")]
        [StringLength(3)]
        public string EntidadFederativa { get; set; }
        [Column("pais_imp_exp")]
        [StringLength(3)]
        public string PaisImpExp { get; set; }
        [Column("fecha_extraccion", TypeName = "datetime")]
        public DateTime? FechaExtraccion { get; set; }
        [Column("fecha_cambio_regimen", TypeName = "datetime")]
        public DateTime? FechaCambioRegimen { get; set; }
        [Column("fecha_presentacion", TypeName = "datetime")]
        public DateTime? FechaPresentacion { get; set; }
        [Column("otros_no_incrementa", TypeName = "decimal(12, 2)")]
        public decimal? OtrosNoIncrementa { get; set; }
        [Column("id_moneda_otros_ni")]
        [StringLength(4)]
        public string IdMonedaOtrosNi { get; set; }
        [Column("factor_otros_ni", TypeName = "decimal(10, 8)")]
        public decimal? FactorOtrosNi { get; set; }
        [Column("otros_no_importe", TypeName = "decimal(12, 0)")]
        public decimal? OtrosNoImporte { get; set; }
        [Column("fecha_original", TypeName = "datetime")]
        public DateTime? FechaOriginal { get; set; }
        [Column("autorizacion_contabilidad")]
        [StringLength(10)]
        public string AutorizacionContabilidad { get; set; }
        [Column("nombre_autorizacion")]
        [StringLength(50)]
        public string NombreAutorizacion { get; set; }
        [Column("Fecha_autorizacion", TypeName = "datetime")]
        public DateTime? FechaAutorizacion { get; set; }
        [Column("art_303_forma_pago")]
        [StringLength(2)]
        public string Art303FormaPago { get; set; }
        [Column("art_303_importe_mn", TypeName = "numeric(12, 0)")]
        public decimal? Art303ImporteMn { get; set; }
        [Column("prevalidacion_tasa", TypeName = "decimal(12, 0)")]
        public decimal? PrevalidacionTasa { get; set; }
        [Column("prevalidacion_importe", TypeName = "decimal(12, 0)")]
        public decimal? PrevalidacionImporte { get; set; }
        [Column("prevalidacion_forma_pago")]
        [StringLength(2)]
        public string PrevalidacionFormaPago { get; set; }
        [Column("prevalidacion_firma")]
        [StringLength(8)]
        public string PrevalidacionFirma { get; set; }
        [Column("prevalidacion_fecha", TypeName = "datetime")]
        public DateTime? PrevalidacionFecha { get; set; }
        [Column("liberado")]
        [StringLength(1)]
        public string Liberado { get; set; }
        [Column("inbond")]
        [StringLength(1)]
        public string Inbond { get; set; }
        [Column("per_firma")]
        [StringLength(6)]
        public string PerFirma { get; set; }
        [Column("per_envio")]
        [StringLength(6)]
        public string PerEnvio { get; set; }
        [Column("identificador")]
        [StringLength(2)]
        public string Identificador { get; set; }
        [Column("multa_importe", TypeName = "decimal(12, 0)")]
        public decimal? MultaImporte { get; set; }
        [Column("multa_fp")]
        [StringLength(2)]
        public string MultaFp { get; set; }
        [Column("referencia_aux")]
        [StringLength(50)]
        public string ReferenciaAux { get; set; }
        [Column("certificado_importe", TypeName = "decimal(12, 0)")]
        public decimal? CertificadoImporte { get; set; }
        [Column("certificado_fp")]
        [StringLength(2)]
        public string CertificadoFp { get; set; }
        [Column("adv_ctagtia_importe", TypeName = "decimal(12, 0)")]
        public decimal? AdvCtagtiaImporte { get; set; }
        [Column("adv_ctagtia_fp")]
        [StringLength(2)]
        public string AdvCtagtiaFp { get; set; }
        [Column("iva_ctagtia_importe", TypeName = "decimal(12, 0)")]
        public decimal? IvaCtagtiaImporte { get; set; }
        [Column("iva_ctagtia_fp")]
        [StringLength(2)]
        public string IvaCtagtiaFp { get; set; }
        [Column("cuo_ctagtia_importe", TypeName = "decimal(12, 0)")]
        public decimal? CuoCtagtiaImporte { get; set; }
        [Column("cuo_ctagtia_fp")]
        [StringLength(2)]
        public string CuoCtagtiaFp { get; set; }
        [Column("isa_ctagtia_importe", TypeName = "decimal(12, 0)")]
        public decimal? IsaCtagtiaImporte { get; set; }
        [Column("isa_ctagtia_fp")]
        [StringLength(2)]
        public string IsaCtagtiaFp { get; set; }
        [Column("iep_ctagtia_importe", TypeName = "decimal(12, 0)")]
        public decimal? IepCtagtiaImporte { get; set; }
        [Column("iep_ctagtia_fp")]
        [StringLength(2)]
        public string IepCtagtiaFp { get; set; }
        [Column("itv_importe", TypeName = "decimal(12, 0)")]
        public decimal? ItvImporte { get; set; }
        [Column("itv_fp")]
        [StringLength(2)]
        public string ItvFp { get; set; }
        [Column("dta_ctagtia_importe", TypeName = "decimal(12, 0)")]
        public decimal? DtaCtagtiaImporte { get; set; }
        [Column("dta_ctagtia_fp")]
        [StringLength(2)]
        public string DtaCtagtiaFp { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("cve_prevalidador")]
        [StringLength(5)]
        public string CvePrevalidador { get; set; }
        [Column("id_moneda_valora")]
        [StringLength(4)]
        public string IdMonedaValora { get; set; }
        [Column("factor_moneda_valor", TypeName = "decimal(10, 8)")]
        public decimal? FactorMonedaValor { get; set; }
        [Column("certificado_importe_fp13", TypeName = "decimal(12, 0)")]
        public decimal? CertificadoImporteFp13 { get; set; }
        [Column("mt_forma_pago")]
        [StringLength(2)]
        public string MtFormaPago { get; set; }
        [Column("mt_importe", TypeName = "numeric(12, 0)")]
        public decimal? MtImporte { get; set; }
        [Column("rfc_servicios")]
        [StringLength(13)]
        public string RfcServicios { get; set; }
        [Column("valor_seguro", TypeName = "decimal(12, 2)")]
        public decimal? ValorSeguro { get; set; }
        [Column("notificacion_pedimento")]
        [StringLength(1)]
        public string NotificacionPedimento { get; set; }
        [Column("forma_pago_eur")]
        [StringLength(2)]
        public string FormaPagoEur { get; set; }
        [Column("importe_eur", TypeName = "numeric(12, 0)")]
        public decimal? ImporteEur { get; set; }
        [Column("multa_tasa", TypeName = "decimal(7, 2)")]
        public decimal? MultaTasa { get; set; }
        [Column("moneda_iva")]
        [StringLength(4)]
        public string MonedaIva { get; set; }
        [Column("firma_precon")]
        [StringLength(8)]
        public string FirmaPrecon { get; set; }
        [Column("contrapres_tasa", TypeName = "decimal(12, 0)")]
        public decimal ContrapresTasa { get; set; }
        [Column("contrapres_importe", TypeName = "decimal(12, 0)")]
        public decimal ContrapresImporte { get; set; }
        [Column("razon_social_servicios")]
        [StringLength(120)]
        public string RazonSocialServicios { get; set; }
        [Column("desbloquear_factura")]
        [StringLength(1)]
        public string DesbloquearFactura { get; set; }
        [Column("campo12")]
        [StringLength(1)]
        public string Campo12 { get; set; }
        [Column("dta_importe_compe", TypeName = "decimal(12, 0)")]
        public decimal? DtaImporteCompe { get; set; }
        [Column("situacion")]
        public short? Situacion { get; set; }
        [Column("plant_code")]
        [StringLength(4)]
        public string PlantCode { get; set; }
        [Column("estimulo_fiscal_ieps", TypeName = "decimal(6, 4)")]
        public decimal? EstimuloFiscalIeps { get; set; }
        [Column("tasa_anual_ieps", TypeName = "decimal(6, 4)")]
        public decimal? TasaAnualIeps { get; set; }
        [Column("firma_desistido")]
        [StringLength(8)]
        public string FirmaDesistido { get; set; }
        [Column("recargo_forma_pago2")]
        [StringLength(2)]
        public string RecargoFormaPago2 { get; set; }
        [Column("recargo_importe2", TypeName = "decimal(12, 0)")]
        public decimal? RecargoImporte2 { get; set; }
        [Column("transpedimentos")]
        [StringLength(1)]
        public string Transpedimentos { get; set; }
        [Column("id_usuario_fprecon")]
        [StringLength(6)]
        public string IdUsuarioFprecon { get; set; }
        [Column("fecha_fprecon", TypeName = "datetime")]
        public DateTime? FechaFprecon { get; set; }
        [Column("departamento")]
        [StringLength(3)]
        public string Departamento { get; set; }
        [Column("opn_banco_pece")]
        [StringLength(14)]
        public string OpnBancoPece { get; set; }
        [Column("listo_WS")]
        public int? ListoWs { get; set; }

        [InverseProperty("IdRe")]
        public virtual FfirmaDigital FfirmaDigital { get; set; }
    }
}
