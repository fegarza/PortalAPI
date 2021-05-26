using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fgenerales2")]
    public partial class Fgenerales2
    {
        [Key]
        [Column("leyenda_instrucciones_embarque")]
        [StringLength(1)]
        public string LeyendaInstruccionesEmbarque { get; set; }
        [Column("leyenda_aduana_embarque")]
        [StringLength(1)]
        public string LeyendaAduanaEmbarque { get; set; }
        [Column("correo_notificacion_embarque")]
        [StringLength(50)]
        public string CorreoNotificacionEmbarque { get; set; }
        [Column("iva_anexo27")]
        [StringLength(1)]
        public string IvaAnexo27 { get; set; }
        [Column("iva_efectivo")]
        [StringLength(1)]
        public string IvaEfectivo { get; set; }
        [Column("password_iva_efectivo")]
        [StringLength(10)]
        public string PasswordIvaEfectivo { get; set; }
        [Column("cliente_proveedor")]
        [StringLength(1)]
        public string ClienteProveedor { get; set; }
        [Column("mismo_archivo_resp")]
        [StringLength(1)]
        public string MismoArchivoResp { get; set; }
        [Column("immex")]
        [StringLength(1)]
        public string Immex { get; set; }
        [Column("password_immex")]
        [StringLength(10)]
        public string PasswordImmex { get; set; }
        [Column("aviso_anexo10")]
        [StringLength(1)]
        public string AvisoAnexo10 { get; set; }
        [Column("valida_vehiculo_PD")]
        [StringLength(1)]
        public string ValidaVehiculoPd { get; set; }
        [Column("valida_vehiculo_password")]
        [StringLength(10)]
        public string ValidaVehiculoPassword { get; set; }
        [Column("password_anexo10")]
        [StringLength(10)]
        public string PasswordAnexo10 { get; set; }
        [Column("ruta_reporte_mensual_light")]
        [StringLength(250)]
        public string RutaReporteMensualLight { get; set; }
        [Column("ficha_fraccion_restriccion")]
        [StringLength(1)]
        public string FichaFraccionRestriccion { get; set; }
        [Column("campo5")]
        [StringLength(1)]
        public string Campo5 { get; set; }
        [Column("contrasena_sdf")]
        [StringLength(30)]
        public string ContrasenaSdf { get; set; }
        [Column("autoriza_validacion")]
        [StringLength(1)]
        public string AutorizaValidacion { get; set; }
        [Column("bultos_completos")]
        [StringLength(1)]
        public string BultosCompletos { get; set; }
        [Column("valida_contenedor")]
        [StringLength(1)]
        public string ValidaContenedor { get; set; }
        [Column("val_pago")]
        [StringLength(1)]
        public string ValPago { get; set; }
        [Column("autoriza_pago_banco")]
        [StringLength(1)]
        public string AutorizaPagoBanco { get; set; }
        [Column("cliente_consec")]
        [StringLength(1)]
        public string ClienteConsec { get; set; }
        [Column("proveedor_consec")]
        [StringLength(1)]
        public string ProveedorConsec { get; set; }
        [Column("valida_contenedores")]
        [StringLength(1)]
        public string ValidaContenedores { get; set; }
        [Column("valida_precio_estimado")]
        [StringLength(1)]
        public string ValidaPrecioEstimado { get; set; }
        [Column("datos_vehic_parteii")]
        [StringLength(1)]
        public string DatosVehicParteii { get; set; }
        [Column("oficina")]
        [StringLength(5)]
        public string Oficina { get; set; }
        [Column("password_rfc_cliente")]
        [StringLength(20)]
        public string PasswordRfcCliente { get; set; }
        [Column("bloquear_pedimento")]
        [StringLength(1)]
        public string BloquearPedimento { get; set; }
        [Column("activar_respaldo_archivos")]
        [StringLength(300)]
        public string ActivarRespaldoArchivos { get; set; }
        [Column("ruta_respaldo_archivos")]
        [StringLength(300)]
        public string RutaRespaldoArchivos { get; set; }
        [Column("patente_aduana_usuario")]
        [StringLength(1)]
        public string PatenteAduanaUsuario { get; set; }
        [Column("busqueda_producto_pref")]
        [StringLength(1)]
        public string BusquedaProductoPref { get; set; }
        [Column("factura_productos_multiples")]
        [StringLength(1)]
        public string FacturaProductosMultiples { get; set; }
        [Column("cove")]
        [StringLength(1)]
        public string Cove { get; set; }
        [Column("vlight")]
        [StringLength(1)]
        public string Vlight { get; set; }
        [Column("bloqueo_campos_clasificacion")]
        [StringLength(1)]
        public string BloqueoCamposClasificacion { get; set; }
        [Column("validar_frac_vulnerables")]
        [StringLength(1)]
        public string ValidarFracVulnerables { get; set; }
        [Column("validar_sintaxis_contenedor")]
        [StringLength(1)]
        public string ValidarSintaxisContenedor { get; set; }
        [Column("correo_ped_simp")]
        [StringLength(50)]
        public string CorreoPedSimp { get; set; }
        [Column("cves_reg_ped_simp")]
        [StringLength(100)]
        public string CvesRegPedSimp { get; set; }
        [Column("autorizar_modif_impuestos")]
        [StringLength(1)]
        public string AutorizarModifImpuestos { get; set; }
        [Column("aviso_conso_ped_cerrado")]
        [StringLength(1)]
        public string AvisoConsoPedCerrado { get; set; }
        [Column("cantidades_parte2")]
        [StringLength(1)]
        public string CantidadesParte2 { get; set; }
        [Column("etiqueta_usuario")]
        [StringLength(1)]
        public string EtiquetaUsuario { get; set; }
        [Column("estimulo_fiscal_ieps", TypeName = "decimal(6, 4)")]
        public decimal? EstimuloFiscalIeps { get; set; }
        [Column("tasa_anual_ieps", TypeName = "decimal(6, 4)")]
        public decimal? TasaAnualIeps { get; set; }
        [Column("envio_centralizado")]
        [StringLength(1)]
        public string EnvioCentralizado { get; set; }
        [Column("valida_buques_mar")]
        [StringLength(1)]
        public string ValidaBuquesMar { get; set; }
        [Column("activa_campos_ped_pagado")]
        [StringLength(1)]
        public string ActivaCamposPedPagado { get; set; }
        [Column("diferencia_cove_remesa")]
        [StringLength(1)]
        public string DiferenciaCoveRemesa { get; set; }
        [Column("copia_vehiculos_consolidado")]
        [StringLength(1)]
        public string CopiaVehiculosConsolidado { get; set; }
        [Column("leer_m3_ped_repetido")]
        [StringLength(1)]
        public string LeerM3PedRepetido { get; set; }
        [Column("ident_obli_clas_traf")]
        [StringLength(1)]
        public string IdentObliClasTraf { get; set; }
        [Column("copiar_cant_tarif")]
        [StringLength(1)]
        public string CopiarCantTarif { get; set; }
        [Column("subir_frac_xml")]
        [StringLength(1)]
        public string SubirFracXml { get; set; }
        [Column("cfdi33")]
        [StringLength(1)]
        public string Cfdi33 { get; set; }
        [Column("validar_igi_pagobanco")]
        [StringLength(1)]
        public string ValidarIgiPagobanco { get; set; }
        [Column("validar_ieps_pagobanco")]
        [StringLength(1)]
        public string ValidarIepsPagobanco { get; set; }
        [Column("contrasena_igi_pagobanco")]
        [StringLength(30)]
        public string ContrasenaIgiPagobanco { get; set; }
        [Column("contrasena_ieps_pagobanco")]
        [StringLength(30)]
        public string ContrasenaIepsPagobanco { get; set; }
        [Column("medio_transporte_default_bodega")]
        [StringLength(2)]
        public string MedioTransporteDefaultBodega { get; set; }
        [Column("ieps_clasificacion")]
        [StringLength(1)]
        public string IepsClasificacion { get; set; }
        [Column("leyenda_imp_partesii")]
        [StringLength(1)]
        public string LeyendaImpPartesii { get; set; }
        [Column("ident_tl_po_clas_prod")]
        [StringLength(1)]
        public string IdentTlPoClasProd { get; set; }
        [Column("ruta_dig_ped_comp_imp")]
        [StringLength(250)]
        public string RutaDigPedCompImp { get; set; }
        [Column("consistencia_cove")]
        [StringLength(1)]
        public string ConsistenciaCove { get; set; }
        [Column("revisa_cove_pedimento")]
        [StringLength(1)]
        public string RevisaCovePedimento { get; set; }
        [Column("tasa_recargo")]
        public double? TasaRecargo { get; set; }
        [Column("dodaqr_url")]
        [StringLength(100)]
        public string DodaqrUrl { get; set; }
        [Column("dodaqr_d1")]
        [StringLength(5)]
        public string DodaqrD1 { get; set; }
        [Column("dodaqr_d2")]
        [StringLength(5)]
        public string DodaqrD2 { get; set; }
        [Column("consecutivo_doda", TypeName = "numeric(7, 0)")]
        public decimal? ConsecutivoDoda { get; set; }
        [Column("auto_doda")]
        [StringLength(1)]
        public string AutoDoda { get; set; }
        [Column("prefijo_doda")]
        [StringLength(3)]
        public string PrefijoDoda { get; set; }
        [Column("horario_verano")]
        [StringLength(1)]
        public string HorarioVerano { get; set; }
        [Column("remesa_terrestre_doda")]
        [StringLength(1)]
        public string RemesaTerrestreDoda { get; set; }
        [Column("doda_combinar_remesas")]
        [StringLength(1)]
        public string DodaCombinarRemesas { get; set; }
        [Column("doda_despacho_aduanero")]
        [StringLength(1)]
        public string DodaDespachoAduanero { get; set; }
        [Column("valida_cove_doda")]
        [StringLength(1)]
        public string ValidaCoveDoda { get; set; }
        [Column("dig_doda_imprimir")]
        [StringLength(1)]
        public string DigDodaImprimir { get; set; }
        [Column("doda_sellos_pedn")]
        [StringLength(1)]
        public string DodaSellosPedn { get; set; }
        [Column("doda_sellos_part2")]
        [StringLength(1)]
        public string DodaSellosPart2 { get; set; }
        [Column("copia_simple")]
        [StringLength(1)]
        public string CopiaSimple { get; set; }
        [Column("no_pedimentos")]
        [StringLength(1)]
        public string NoPedimentos { get; set; }
        [Column("copia_transportista_pII")]
        [StringLength(1)]
        public string CopiaTransportistaPIi { get; set; }
        [Column("actualiza_facturas_partidas")]
        [StringLength(1)]
        public string ActualizaFacturasPartidas { get; set; }
        [Column("pass_autoriza_irs")]
        [StringLength(1)]
        public string PassAutorizaIrs { get; set; }
        [Column("password_taxid_repetido")]
        [StringLength(30)]
        public string PasswordTaxidRepetido { get; set; }
        [Column("bloqueo_botones_relacion_docs")]
        [StringLength(1)]
        public string BloqueoBotonesRelacionDocs { get; set; }
        [Column("guias_repetidas_bodega")]
        [StringLength(1)]
        public string GuiasRepetidasBodega { get; set; }
        [Column("sextaenmienda")]
        [StringLength(1)]
        public string Sextaenmienda { get; set; }
    }
}
