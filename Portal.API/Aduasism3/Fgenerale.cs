using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("fgenerales")]
    public partial class Fgenerale
    {
        [Column("dta_cuota_fija", TypeName = "numeric(12, 0)")]
        public decimal DtaCuotaFija { get; set; }
        [Column("porc_mayor_adval", TypeName = "numeric(5, 2)")]
        public decimal PorcMayorAdval { get; set; }
        [Column("id_fraccion")]
        [StringLength(8)]
        public string IdFraccion { get; set; }
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Column("seccion")]
        [StringLength(1)]
        public string Seccion { get; set; }
        [Column("id_patente")]
        [StringLength(4)]
        public string IdPatente { get; set; }
        [Column("shcp_validacion")]
        [StringLength(50)]
        public string ShcpValidacion { get; set; }
        [Column("shcp_error")]
        [StringLength(50)]
        public string ShcpError { get; set; }
        [Column("banco_validacion")]
        [StringLength(50)]
        public string BancoValidacion { get; set; }
        [Column("banco_error")]
        [StringLength(50)]
        public string BancoError { get; set; }
        [Column("sagar_validacion")]
        [StringLength(50)]
        public string SagarValidacion { get; set; }
        [Column("sagar_error")]
        [StringLength(50)]
        public string SagarError { get; set; }
        [Column("aaa_validacion")]
        [StringLength(50)]
        public string AaaValidacion { get; set; }
        [Column("aaa_error")]
        [StringLength(50)]
        public string AaaError { get; set; }
        [Column("archivo_producto")]
        [StringLength(30)]
        public string ArchivoProducto { get; set; }
        [Column("path_producto")]
        [StringLength(50)]
        public string PathProducto { get; set; }
        [Column("prefijo_entrada")]
        [StringLength(3)]
        public string PrefijoEntrada { get; set; }
        [Column("prefijo_trafico")]
        [StringLength(3)]
        public string PrefijoTrafico { get; set; }
        [Column("prefijo_embarque")]
        [StringLength(3)]
        public string PrefijoEmbarque { get; set; }
        [Column("prefijo_referencia")]
        [StringLength(3)]
        public string PrefijoReferencia { get; set; }
        [Column("auto_entrada")]
        [StringLength(1)]
        public string AutoEntrada { get; set; }
        [Column("auto_trafico")]
        [StringLength(1)]
        public string AutoTrafico { get; set; }
        [Column("auto_embarque")]
        [StringLength(1)]
        public string AutoEmbarque { get; set; }
        [Column("auto_calculo")]
        [StringLength(1)]
        public string AutoCalculo { get; set; }
        [Column("auto_referencia")]
        [StringLength(1)]
        public string AutoReferencia { get; set; }
        [Column("auto_pedimento")]
        [StringLength(1)]
        public string AutoPedimento { get; set; }
        [Column("password_pedimento")]
        [StringLength(10)]
        public string PasswordPedimento { get; set; }
        [Column("auto_shipper")]
        [StringLength(1)]
        public string AutoShipper { get; set; }
        [Column("id_forwarding")]
        [StringLength(8)]
        public string IdForwarding { get; set; }
        [Column("id_agencia_aduanal")]
        [StringLength(4)]
        public string IdAgenciaAduanal { get; set; }
        [Column("id_bodega")]
        [StringLength(8)]
        public string IdBodega { get; set; }
        [Column("prefijo_ferrocarril")]
        [StringLength(3)]
        public string PrefijoFerrocarril { get; set; }
        [Column("auto_ferrocarril")]
        [StringLength(1)]
        public string AutoFerrocarril { get; set; }
        [Column("marcas_entrada")]
        [StringLength(1)]
        public string MarcasEntrada { get; set; }
        [Column("tipo_arribo")]
        [StringLength(1)]
        public string TipoArribo { get; set; }
        [Column("id_moneda")]
        [StringLength(4)]
        public string IdMoneda { get; set; }
        [Column("situacion")]
        [StringLength(1)]
        public string Situacion { get; set; }
        [Column("seccion_bod")]
        [StringLength(1)]
        public string SeccionBod { get; set; }
        [Column("fecha_dta", TypeName = "datetime")]
        public DateTime? FechaDta { get; set; }
        [Column("garantia_porcentaje", TypeName = "numeric(5, 2)")]
        public decimal? GarantiaPorcentaje { get; set; }
        [Column("ID_CLIENTE")]
        [StringLength(4)]
        public string IdCliente { get; set; }
        [Column("shcp_validacion2")]
        [StringLength(50)]
        public string ShcpValidacion2 { get; set; }
        [Column("shcp_error2")]
        [StringLength(50)]
        public string ShcpError2 { get; set; }
        [Column("banco_validacion2")]
        [StringLength(50)]
        public string BancoValidacion2 { get; set; }
        [Column("banco_error2")]
        [StringLength(50)]
        public string BancoError2 { get; set; }
        [Column("shcp_validacion3")]
        [StringLength(50)]
        public string ShcpValidacion3 { get; set; }
        [Column("shcp_error3")]
        [StringLength(50)]
        public string ShcpError3 { get; set; }
        [Column("banco_validacion3")]
        [StringLength(50)]
        public string BancoValidacion3 { get; set; }
        [Column("banco_error3")]
        [StringLength(50)]
        public string BancoError3 { get; set; }
        [Column("dias_inbond", TypeName = "numeric(3, 0)")]
        public decimal? DiasInbond { get; set; }
        [Column("anexo_cliente")]
        [StringLength(1)]
        public string AnexoCliente { get; set; }
        [Column("sagar_validacion2")]
        [StringLength(50)]
        public string SagarValidacion2 { get; set; }
        [Column("sagar_error2")]
        [StringLength(50)]
        public string SagarError2 { get; set; }
        [Column("sagar_validacion3")]
        [StringLength(50)]
        public string SagarValidacion3 { get; set; }
        [Column("sagar_error3")]
        [StringLength(50)]
        public string SagarError3 { get; set; }
        [Column("pedimento_trafico")]
        [StringLength(1)]
        public string PedimentoTrafico { get; set; }
        [Column("consecutivo_partidas")]
        [StringLength(1)]
        public string ConsecutivoPartidas { get; set; }
        [Column("id_tipo_factura")]
        [StringLength(4)]
        public string IdTipoFactura { get; set; }
        [Column("control_bultos")]
        [StringLength(1)]
        public string ControlBultos { get; set; }
        [Column("dta_rectificacion", TypeName = "numeric(12, 0)")]
        public decimal? DtaRectificacion { get; set; }
        [Column("dta_exportacion", TypeName = "numeric(12, 0)")]
        public decimal? DtaExportacion { get; set; }
        [Column("dta_embajada", TypeName = "numeric(12, 0)")]
        public decimal? DtaEmbajada { get; set; }
        [Column("dta_oro", TypeName = "numeric(12, 0)")]
        public decimal? DtaOro { get; set; }
        [Column("autorizacion_contabilidad")]
        [StringLength(1)]
        public string AutorizacionContabilidad { get; set; }
        [Column("poliza_electronica")]
        [StringLength(1)]
        public string PolizaElectronica { get; set; }
        [Column("num_ped_trafico")]
        [StringLength(1)]
        public string NumPedTrafico { get; set; }
        [Column("guia_req")]
        [StringLength(1)]
        public string GuiaReq { get; set; }
        [Column("prevalidacion_tasa", TypeName = "decimal(12, 0)")]
        public decimal? PrevalidacionTasa { get; set; }
        [Column("prevalidacion_error")]
        [StringLength(50)]
        public string PrevalidacionError { get; set; }
        [Column("prevalidacion_error2")]
        [StringLength(50)]
        public string PrevalidacionError2 { get; set; }
        [Column("prevalidacion_error3")]
        [StringLength(50)]
        public string PrevalidacionError3 { get; set; }
        [Column("entrada_trafico")]
        [StringLength(1)]
        public string EntradaTrafico { get; set; }
        [Column("peso_embarque", TypeName = "numeric(15, 3)")]
        public decimal? PesoEmbarque { get; set; }
        [Column("tipo_tasa_rec")]
        [StringLength(1)]
        public string TipoTasaRec { get; set; }
        [Column("ruta_validador")]
        [StringLength(50)]
        public string RutaValidador { get; set; }
        [Column("carta_enc")]
        [StringLength(1)]
        public string CartaEnc { get; set; }
        [Column("profepa_validacion")]
        [StringLength(50)]
        public string ProfepaValidacion { get; set; }
        [Column("profepa_error")]
        [StringLength(50)]
        public string ProfepaError { get; set; }
        [Column("carta_validacion")]
        [StringLength(50)]
        public string CartaValidacion { get; set; }
        [Column("carta_error")]
        [StringLength(50)]
        public string CartaError { get; set; }
        [Column("Encargo_path")]
        [StringLength(50)]
        public string EncargoPath { get; set; }
        [Column("Encargo_error")]
        [StringLength(50)]
        public string EncargoError { get; set; }
        [Column("drive_aux")]
        [StringLength(50)]
        public string DriveAux { get; set; }
        [Column("shcp_valid_aux")]
        [StringLength(50)]
        public string ShcpValidAux { get; set; }
        [Column("shcp_error_aux")]
        [StringLength(50)]
        public string ShcpErrorAux { get; set; }
        [Column("banco_valid_aux")]
        [StringLength(50)]
        public string BancoValidAux { get; set; }
        [Column("banco_error_aux")]
        [StringLength(50)]
        public string BancoErrorAux { get; set; }
        [Column("sagar_valid_aux")]
        [StringLength(50)]
        public string SagarValidAux { get; set; }
        [Column("sagar_error_aux")]
        [StringLength(50)]
        public string SagarErrorAux { get; set; }
        [Column("firma_auto")]
        [StringLength(1)]
        public string FirmaAuto { get; set; }
        [Column("adu_consec")]
        [StringLength(3)]
        public string AduConsec { get; set; }
        [Column("lic_ship")]
        [StringLength(10)]
        public string LicShip { get; set; }
        [Column("ruta_archivo_aux")]
        [StringLength(50)]
        public string RutaArchivoAux { get; set; }
        [Column("ruta_archivo_aux2")]
        [StringLength(50)]
        public string RutaArchivoAux2 { get; set; }
        [Column("aduana_aux")]
        [StringLength(3)]
        public string AduanaAux { get; set; }
        [Column("aduana_aux2")]
        [StringLength(3)]
        public string AduanaAux2 { get; set; }
        [Column("prefijo_control")]
        [StringLength(3)]
        public string PrefijoControl { get; set; }
        [Column("auto_control")]
        [StringLength(1)]
        public string AutoControl { get; set; }
        [Column("deposito_arch")]
        [StringLength(50)]
        public string DepositoArch { get; set; }
        [Column("ruta_archivo_aux3")]
        [StringLength(50)]
        public string RutaArchivoAux3 { get; set; }
        [Column("ruta_archivo_aux4")]
        [StringLength(50)]
        public string RutaArchivoAux4 { get; set; }
        [Column("ruta_archivo_aux5")]
        [StringLength(50)]
        public string RutaArchivoAux5 { get; set; }
        [Column("aduana_aux3")]
        [StringLength(3)]
        public string AduanaAux3 { get; set; }
        [Column("aduana_aux4")]
        [StringLength(3)]
        public string AduanaAux4 { get; set; }
        [Column("aduana_aux5")]
        [StringLength(3)]
        public string AduanaAux5 { get; set; }
        [Column("protege_fecha_cruce")]
        [StringLength(1)]
        public string ProtegeFechaCruce { get; set; }
        [Column("tasa_certificado", TypeName = "decimal(18, 0)")]
        public decimal? TasaCertificado { get; set; }
        [Column("tipo_tasa_certificado")]
        [StringLength(1)]
        public string TipoTasaCertificado { get; set; }
        [Column("dia")]
        [StringLength(1)]
        public string Dia { get; set; }
        [Column("firmaelectronica")]
        [StringLength(250)]
        public string Firmaelectronica { get; set; }
        [Column("aaaa_anexo18")]
        [StringLength(4)]
        public string AaaaAnexo18 { get; set; }
        [Column("path_files")]
        [StringLength(250)]
        public string PathFiles { get; set; }
        [Column("fea_automatica")]
        [StringLength(1)]
        public string FeaAutomatica { get; set; }
        [Column("drive_fea_automatica")]
        [StringLength(1)]
        public string DriveFeaAutomatica { get; set; }
        [Column("cierre_auto")]
        [StringLength(1)]
        public string CierreAuto { get; set; }
        [Column("firmaelectronica2")]
        [StringLength(250)]
        public string Firmaelectronica2 { get; set; }
        [Column("ref_aux_requerido")]
        [StringLength(1)]
        public string RefAuxRequerido { get; set; }
        [Column("actividades")]
        [StringLength(1)]
        public string Actividades { get; set; }
        [Column("cliente_numerico")]
        [StringLength(1)]
        public string ClienteNumerico { get; set; }
        [Column("mt_tipo_tasa")]
        [StringLength(2)]
        public string MtTipoTasa { get; set; }
        [Column("reg_557_mixto")]
        [StringLength(1)]
        public string Reg557Mixto { get; set; }
        [Column("fotos_embarque")]
        [StringLength(120)]
        public string FotosEmbarque { get; set; }
        [Column("fotos_entrada")]
        [StringLength(120)]
        public string FotosEntrada { get; set; }
        [Column("auto_entrada_folio")]
        [StringLength(1)]
        public string AutoEntradaFolio { get; set; }
        [Column("prefijo_entrada_folio")]
        [StringLength(3)]
        public string PrefijoEntradaFolio { get; set; }
        [Column("formato_fechas")]
        [StringLength(1)]
        public string FormatoFechas { get; set; }
        [Column("notif_pago_elec")]
        public bool NotifPagoElec { get; set; }
        [Column("correos_electronicos")]
        [StringLength(250)]
        public string CorreosElectronicos { get; set; }
        [Column("codigo_x_factura_remesa")]
        [StringLength(1)]
        public string CodigoXFacturaRemesa { get; set; }
        [Column("path_archivos_generados")]
        [StringLength(120)]
        public string PathArchivosGenerados { get; set; }
        [Column("d_operacion")]
        [StringLength(1)]
        public string DOperacion { get; set; }
        [Column("d_descripcion")]
        [StringLength(1)]
        public string DDescripcion { get; set; }
        [Column("d_derogadas")]
        [StringLength(1)]
        public string DDerogadas { get; set; }
        [Column("d_tasas")]
        [StringLength(1)]
        public string DTasas { get; set; }
        [Column("d_formato")]
        [StringLength(1)]
        public string DFormato { get; set; }
        [Column("d_mensajes")]
        [StringLength(1)]
        public string DMensajes { get; set; }
        [Column("ruta_digitalizar_factura")]
        [StringLength(256)]
        public string RutaDigitalizarFactura { get; set; }
        [Column("ruta_nota_revision")]
        [StringLength(256)]
        public string RutaNotaRevision { get; set; }
        [Column("fea_consolidado")]
        [StringLength(1)]
        public string FeaConsolidado { get; set; }
        [Column("rfc_servicios")]
        [StringLength(13)]
        public string RfcServicios { get; set; }
        [Column("password_bancos")]
        [StringLength(10)]
        public string PasswordBancos { get; set; }
        [Column("usa_wms")]
        [StringLength(1)]
        public string UsaWms { get; set; }
        [Column("ruta_xml")]
        [StringLength(100)]
        public string RutaXml { get; set; }
        [Column("modificar_trafico")]
        [StringLength(1)]
        public string ModificarTrafico { get; set; }
        [Column("ped_auto")]
        [StringLength(1)]
        public string PedAuto { get; set; }
        [Column("prefijo_lec_auto")]
        [StringLength(3)]
        public string PrefijoLecAuto { get; set; }
        [Column("ruta_ped_auto")]
        [StringLength(250)]
        public string RutaPedAuto { get; set; }
        [Column("identificador_pd")]
        [StringLength(1)]
        public string IdentificadorPd { get; set; }
        [Column("fecha_consulta", TypeName = "smalldatetime")]
        public DateTime? FechaConsulta { get; set; }
        [Column("prod_quimico")]
        [StringLength(1)]
        public string ProdQuimico { get; set; }
        [Column("boton_factura")]
        [StringLength(1)]
        public string BotonFactura { get; set; }
        [Column("boton_transportista")]
        [StringLength(1)]
        public string BotonTransportista { get; set; }
        [Column("boton_guias")]
        [StringLength(1)]
        public string BotonGuias { get; set; }
        [Column("boton_contenedor")]
        [StringLength(1)]
        public string BotonContenedor { get; set; }
        [Column("boton_identificador")]
        [StringLength(1)]
        public string BotonIdentificador { get; set; }
        [Column("boton_descargas")]
        [StringLength(1)]
        public string BotonDescargas { get; set; }
        [Column("boton_obsevaciones")]
        [StringLength(1)]
        public string BotonObsevaciones { get; set; }
        [Column("boton_vehiculos")]
        [StringLength(1)]
        public string BotonVehiculos { get; set; }
        [Column("boton_bultos")]
        [StringLength(1)]
        public string BotonBultos { get; set; }
        [Column("boton_cta_aduanera")]
        [StringLength(1)]
        public string BotonCtaAduanera { get; set; }
        [Column("boton_compensacion")]
        [StringLength(1)]
        public string BotonCompensacion { get; set; }
        [Column("boton_partidas")]
        [StringLength(1)]
        public string BotonPartidas { get; set; }
        [Column("boton_impuestos")]
        [StringLength(1)]
        public string BotonImpuestos { get; set; }
        [Column("boton_diferencias")]
        [StringLength(1)]
        public string BotonDiferencias { get; set; }
        [Column("PDF_ENTRADA")]
        [StringLength(180)]
        public string PdfEntrada { get; set; }
        [Column("certificado_sagar")]
        [StringLength(1)]
        public string CertificadoSagar { get; set; }
        [Column("monedas_facturas")]
        [StringLength(1)]
        public string MonedasFacturas { get; set; }
        [Column("estado_largo")]
        [StringLength(1)]
        public string EstadoLargo { get; set; }
        [Column("prefijo_recibo")]
        [StringLength(3)]
        public string PrefijoRecibo { get; set; }
        [Column("auto_recibo")]
        [StringLength(1)]
        public string AutoRecibo { get; set; }
        [Column("prefijo_embarque_light")]
        [StringLength(3)]
        public string PrefijoEmbarqueLight { get; set; }
        [Column("auto_embarque_light")]
        [StringLength(1)]
        public string AutoEmbarqueLight { get; set; }
        [Column("propagar")]
        [StringLength(1)]
        public string Propagar { get; set; }
        [Column("traf_embarque")]
        [StringLength(1)]
        public string TrafEmbarque { get; set; }
        [Column("imp_eti_auto")]
        [StringLength(1)]
        public string ImpEtiAuto { get; set; }
        [Column("pasar_vc")]
        [StringLength(1)]
        public string PasarVc { get; set; }
        [Column("pasar_vc_consol")]
        [StringLength(1)]
        public string PasarVcConsol { get; set; }
        [Column("conoc_emb_valid")]
        [StringLength(120)]
        public string ConocEmbValid { get; set; }
        [Column("conoc_emb_error")]
        [StringLength(120)]
        public string ConocEmbError { get; set; }
        [Column("fecha_visor", TypeName = "datetime")]
        public DateTime? FechaVisor { get; set; }
        [Column("validar_firmas")]
        [StringLength(1)]
        public string ValidarFirmas { get; set; }
        [Column("bloquear_campos_factura")]
        [StringLength(1)]
        public string BloquearCamposFactura { get; set; }
        [Column("leyenda_cotizacion")]
        [StringLength(1)]
        public string LeyendaCotizacion { get; set; }
        [Column("pedmto_automatico")]
        [StringLength(1)]
        public string PedmtoAutomatico { get; set; }
        [Column("ruta_firma_electronica")]
        [StringLength(50)]
        public string RutaFirmaElectronica { get; set; }
        [Column("reg_500s")]
        [StringLength(1)]
        public string Reg500s { get; set; }
        [Column("consecutivo_proveedor")]
        [StringLength(1)]
        public string ConsecutivoProveedor { get; set; }
        [Column("validar_formato_fecha")]
        [StringLength(1)]
        public string ValidarFormatoFecha { get; set; }
        [Column("calculo_auto")]
        [StringLength(1)]
        public string CalculoAuto { get; set; }
        [Column("validar_cant_tarifa")]
        [StringLength(1)]
        public string ValidarCantTarifa { get; set; }
        [Column("CORREO_BLAT")]
        [StringLength(1)]
        public string CorreoBlat { get; set; }
        [Column("actualiza_fecha_cruce")]
        [StringLength(1)]
        public string ActualizaFechaCruce { get; set; }
        [Column("asigna_ident")]
        [StringLength(1)]
        public string AsignaIdent { get; set; }
        [Column("peso_partida")]
        [StringLength(1)]
        public string PesoPartida { get; set; }
        [Column("sum_peso_bulto")]
        [StringLength(1)]
        public string SumPesoBulto { get; set; }
        [Column("banco_candado")]
        [StringLength(1)]
        public string BancoCandado { get; set; }
        [Column("envio_pedimento")]
        [StringLength(1)]
        public string EnvioPedimento { get; set; }
        [Column("peso_entrada_a_bulto")]
        [StringLength(1)]
        public string PesoEntradaABulto { get; set; }
        [Column("seccion_requerida")]
        [StringLength(1)]
        public string SeccionRequerida { get; set; }
        [Column("valida_copia_descripcion")]
        [StringLength(1)]
        public string ValidaCopiaDescripcion { get; set; }
        [Column("multa_tasa", TypeName = "decimal(7, 2)")]
        public decimal? MultaTasa { get; set; }
        [Column("dig_ped_firma_banco")]
        [StringLength(1)]
        public string DigPedFirmaBanco { get; set; }
        [Column("ruta_dig_ped_firma_banco")]
        [StringLength(120)]
        public string RutaDigPedFirmaBanco { get; set; }
        [Column("archivos_pedimentos")]
        [StringLength(250)]
        public string ArchivosPedimentos { get; set; }
        [Column("candado_reg516")]
        [StringLength(1)]
        public string CandadoReg516 { get; set; }
        [Column("cod_con_virtual")]
        [StringLength(1)]
        public string CodConVirtual { get; set; }
        [Column("campos_eei_req")]
        [StringLength(1)]
        public string CamposEeiReq { get; set; }
        [Column("val_boton_bul_tra")]
        [StringLength(1)]
        public string ValBotonBulTra { get; set; }
        [Column("cove")]
        [StringLength(1)]
        public string Cove { get; set; }
        [Column("valida_sello_embarque")]
        [StringLength(1)]
        public string ValidaSelloEmbarque { get; set; }
        [Column("bulto_kgs")]
        [StringLength(1)]
        public string BultoKgs { get; set; }
        [Column("obser_partida_trafi")]
        [StringLength(1)]
        public string ObserPartidaTrafi { get; set; }
        [Column("obser_partida_orden")]
        [StringLength(1)]
        public string ObserPartidaOrden { get; set; }
        [Column("valida_trafico_calculo")]
        [StringLength(1)]
        public string ValidaTraficoCalculo { get; set; }
        [Column("notificacion_embarque")]
        [StringLength(1)]
        public string NotificacionEmbarque { get; set; }
        [Column("imprimir_destino")]
        [StringLength(1)]
        public string ImprimirDestino { get; set; }
        [Column("actualiza_advalorem")]
        [StringLength(1)]
        public string ActualizaAdvalorem { get; set; }
        [Column("actualiza_identificadores")]
        [StringLength(1)]
        public string ActualizaIdentificadores { get; set; }
        [Column("facturar_a")]
        [StringLength(1)]
        public string FacturarA { get; set; }
        [Column("archivo_z")]
        [StringLength(1)]
        public string ArchivoZ { get; set; }
        [Column("mv_auto")]
        [StringLength(1)]
        public string MvAuto { get; set; }
        [Column("leyenda_copias")]
        [StringLength(1)]
        public string LeyendaCopias { get; set; }
        [Column("relEntradaDoctos")]
        public bool? RelEntradaDoctos { get; set; }
        [Column("firma_simplificado")]
        public bool? FirmaSimplificado { get; set; }
        [Column("caat_relacion")]
        [StringLength(1)]
        public string CaatRelacion { get; set; }
        [Column("cove_password")]
        [StringLength(20)]
        public string CovePassword { get; set; }
        [Column("partes2_consecutivo")]
        [StringLength(1)]
        public string Partes2Consecutivo { get; set; }
        [Column("ocultar_cuadro_liquidacion")]
        [StringLength(1)]
        public string OcultarCuadroLiquidacion { get; set; }
        [Column("imprimir_remesa")]
        [StringLength(1)]
        public string ImprimirRemesa { get; set; }
        [Column("fpago_perfil")]
        [StringLength(1)]
        public string FpagoPerfil { get; set; }
        [Column("milestone")]
        public bool? Milestone { get; set; }
        [Column("ruta_modulo_pedimentos")]
        [StringLength(100)]
        public string RutaModuloPedimentos { get; set; }
        [Column("ruta_modulo_traficos")]
        [StringLength(100)]
        public string RutaModuloTraficos { get; set; }
        [Column("campo13_codigo")]
        [StringLength(1)]
        public string Campo13Codigo { get; set; }
        [Column("desc_pais")]
        [StringLength(1)]
        public string DescPais { get; set; }
        [Column("shcp_validacion4")]
        [StringLength(50)]
        public string ShcpValidacion4 { get; set; }
        [Column("shcp_error4")]
        [StringLength(50)]
        public string ShcpError4 { get; set; }
        [Column("banco_validacion4")]
        [StringLength(50)]
        public string BancoValidacion4 { get; set; }
        [Column("banco_error4")]
        [StringLength(50)]
        public string BancoError4 { get; set; }
        [Column("sagar_validacion4")]
        [StringLength(50)]
        public string SagarValidacion4 { get; set; }
        [Column("sagar_error4")]
        [StringLength(50)]
        public string SagarError4 { get; set; }
        [Column("prevalidacion_error4")]
        [StringLength(50)]
        public string PrevalidacionError4 { get; set; }
        [Column("m3505")]
        public bool? M3505 { get; set; }
        [Column("validacion_pedimentos")]
        [StringLength(1)]
        public string ValidacionPedimentos { get; set; }
        [Column("validar_cliente_proveedor")]
        [StringLength(1)]
        public string ValidarClienteProveedor { get; set; }
        [Column("ruta_archivos_dat")]
        [StringLength(260)]
        public string RutaArchivosDat { get; set; }
        [Column("contenedor_auto")]
        [StringLength(1)]
        public string ContenedorAuto { get; set; }
        [Required]
        [Column("pedimento_marcaDeAgua")]
        [StringLength(1)]
        public string PedimentoMarcaDeAgua { get; set; }
        [Column("pdf417")]
        [StringLength(1)]
        public string Pdf417 { get; set; }
        [Column("leyenda_copias_parte_2")]
        [StringLength(1)]
        public string LeyendaCopiasParte2 { get; set; }
        [Column("fracciones_vulnerables")]
        [StringLength(1)]
        public string FraccionesVulnerables { get; set; }
        [Column("autorizacion_r1")]
        [StringLength(1)]
        public string AutorizacionR1 { get; set; }
        [Column("tipo_tasa_rec_a3")]
        [StringLength(1)]
        public string TipoTasaRecA3 { get; set; }
        [Column("notif_ped_rec1")]
        [StringLength(1)]
        public string NotifPedRec1 { get; set; }
        [Column("contrapres_tasa", TypeName = "decimal(12, 0)")]
        public decimal ContrapresTasa { get; set; }
        [Required]
        [Column("tipo_prev")]
        [StringLength(1)]
        public string TipoPrev { get; set; }
        [Column("cuadro_liquidacion_oculto")]
        [StringLength(1)]
        public string CuadroLiquidacionOculto { get; set; }
        [Column("notificacion_mv")]
        [StringLength(1)]
        public string NotificacionMv { get; set; }
        [Column("notificacion_hc")]
        [StringLength(1)]
        public string NotificacionHc { get; set; }
        [Column("sis_fea")]
        [StringLength(1)]
        public string SisFea { get; set; }
        [Column("ruta_guardar_anexo24")]
        [StringLength(250)]
        public string RutaGuardarAnexo24 { get; set; }
        [Column("banco_fracc_vulnerables")]
        [StringLength(1)]
        public string BancoFraccVulnerables { get; set; }
        [Column("validar_vigencia")]
        [StringLength(1)]
        public string ValidarVigencia { get; set; }
        [Column("password_autorizacion_pago_cuenta_cliente")]
        [StringLength(30)]
        public string PasswordAutorizacionPagoCuentaCliente { get; set; }
        [Column("actualiza_entrada")]
        [StringLength(1)]
        public string ActualizaEntrada { get; set; }
        [Column("cambio_formato_pedimento")]
        [StringLength(100)]
        public string CambioFormatoPedimento { get; set; }
        [Column("password_validacion_marca")]
        [StringLength(12)]
        public string PasswordValidacionMarca { get; set; }
        [Column("password_validacion_economia")]
        [StringLength(12)]
        public string PasswordValidacionEconomia { get; set; }
        [Column("campo_nota_revision")]
        [StringLength(13)]
        public string CampoNotaRevision { get; set; }
        [Column("iva_anexo_27")]
        [StringLength(1)]
        public string IvaAnexo27 { get; set; }
        [Column("activar_rfc_servicios_cliente")]
        [StringLength(1)]
        public string ActivarRfcServiciosCliente { get; set; }
        [Column("clasificacion_trafico")]
        [StringLength(1)]
        public string ClasificacionTrafico { get; set; }
        [Column("rest_horario")]
        [StringLength(1)]
        public string RestHorario { get; set; }
        [Column("rest_horario_password")]
        [StringLength(30)]
        public string RestHorarioPassword { get; set; }
        [Column("valor_agregado")]
        [StringLength(1)]
        public string ValorAgregado { get; set; }
        [Column("correo_smtp")]
        [StringLength(1)]
        public string CorreoSmtp { get; set; }
        [Column("smtp_server")]
        [StringLength(200)]
        public string SmtpServer { get; set; }
        [Column("smtp_port")]
        public int? SmtpPort { get; set; }
        [Column("smtp_from")]
        [StringLength(200)]
        public string SmtpFrom { get; set; }
        [Column("smtp_mail")]
        [StringLength(200)]
        public string SmtpMail { get; set; }
        [Column("smtp_password")]
        [StringLength(200)]
        public string SmtpPassword { get; set; }
        [Column("smtp_encrypt_type")]
        [StringLength(1)]
        public string SmtpEncryptType { get; set; }
        [Column("anexo_10")]
        [StringLength(1)]
        public string Anexo10 { get; set; }
        [Column("anexo_10_password")]
        [StringLength(30)]
        public string Anexo10Password { get; set; }
        [Column("mod_ferrocarril")]
        [StringLength(1)]
        public string ModFerrocarril { get; set; }
        [Column("perm_pagar_cuenta_general")]
        [StringLength(1)]
        public string PermPagarCuentaGeneral { get; set; }
        [Column("campo12")]
        [StringLength(2)]
        public string Campo12 { get; set; }
        [Column("peso_limite_REOR", TypeName = "numeric(14, 3)")]
        public decimal? PesoLimiteReor { get; set; }
        [Column("password_aut_peso")]
        [StringLength(10)]
        public string PasswordAutPeso { get; set; }
        [Column("valor_seguro_mayor")]
        [StringLength(1)]
        public string ValorSeguroMayor { get; set; }
        [Column("bloqueo_campos_aduasis_cove")]
        [StringLength(1)]
        public string BloqueoCamposAduasisCove { get; set; }
        [Column("fecha_inicial_contingencia", TypeName = "datetime")]
        public DateTime? FechaInicialContingencia { get; set; }
        [Column("fecha_final_contingencia", TypeName = "datetime")]
        public DateTime? FechaFinalContingencia { get; set; }
        [Column("path_digitaliza")]
        [StringLength(120)]
        public string PathDigitaliza { get; set; }
        [Column("JWT_DODA")]
        public string JwtDoda { get; set; }
    }
}
