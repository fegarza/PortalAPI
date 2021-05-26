using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("FCLIENTE")]
    [Index(nameof(Rowguid), Name = "index_1924917929", IsUnique = true)]
    public partial class Fcliente
    {
        public Fcliente()
        {
            FclienteEscapes = new HashSet<FclienteEscape>();
            Fescapes = new HashSet<Fescape>();
            FrelClienteProveedors = new HashSet<FrelClienteProveedor>();
        }

        [Key]
        [Column("ID_CLIENTE")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Required]
        [Column("RAZON_SOCIAL")]
        [StringLength(120)]
        public string RazonSocial { get; set; }
        [Required]
        [Column("razon_social_abreviada")]
        [StringLength(10)]
        public string RazonSocialAbreviada { get; set; }
        [Required]
        [Column("RFC")]
        [StringLength(13)]
        public string Rfc { get; set; }
        [Column("correo_electronico")]
        [StringLength(50)]
        public string CorreoElectronico { get; set; }
        [Column("cve_telefono")]
        [StringLength(10)]
        public string CveTelefono { get; set; }
        [Column("fax")]
        [StringLength(15)]
        public string Fax { get; set; }
        [Column("telefono1")]
        [StringLength(15)]
        public string Telefono1 { get; set; }
        [Column("telefono2")]
        [StringLength(15)]
        public string Telefono2 { get; set; }
        [Column("telefono3")]
        [StringLength(15)]
        public string Telefono3 { get; set; }
        [Column("telefono4")]
        [StringLength(15)]
        public string Telefono4 { get; set; }
        [Column("calle")]
        [StringLength(80)]
        public string Calle { get; set; }
        [Column("numero")]
        [StringLength(10)]
        public string Numero { get; set; }
        [Column("colonia")]
        [StringLength(60)]
        public string Colonia { get; set; }
        [Column("codigo_postal")]
        [StringLength(10)]
        public string CodigoPostal { get; set; }
        [Column("id_municipio")]
        [StringLength(4)]
        public string IdMunicipio { get; set; }
        [Required]
        [Column("cve_cliente")]
        [StringLength(1)]
        public string CveCliente { get; set; }
        [Required]
        [Column("cve_tipo_empresa")]
        [StringLength(3)]
        public string CveTipoEmpresa { get; set; }
        [Required]
        [Column("id_corresponsal")]
        [StringLength(6)]
        public string IdCorresponsal { get; set; }
        [Column("FERR_ESCAPE")]
        [StringLength(40)]
        public string FerrEscape { get; set; }
        [Column("FERR_ESTACION")]
        [StringLength(40)]
        public string FerrEstacion { get; set; }
        [Column("ferr_apoderado")]
        [StringLength(30)]
        public string FerrApoderado { get; set; }
        [Column("RNIM_RNPP")]
        [StringLength(30)]
        public string RnimRnpp { get; set; }
        [Column("NUM_PROGRAMA")]
        [StringLength(15)]
        public string NumPrograma { get; set; }
        [Column("num_planta")]
        [StringLength(8)]
        public string NumPlanta { get; set; }
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
        [Column("dias_despacho", TypeName = "numeric(4, 2)")]
        public decimal? DiasDespacho { get; set; }
        [Column("id_bodega")]
        [StringLength(2)]
        public string IdBodega { get; set; }
        [Column("dias_libres_almacenaje", TypeName = "numeric(5, 0)")]
        public decimal? DiasLibresAlmacenaje { get; set; }
        [StringLength(18)]
        public string Curp { get; set; }
        [Column("Numero_Interior")]
        [StringLength(10)]
        public string NumeroInterior { get; set; }
        [Column("dias_credito", TypeName = "numeric(5, 0)")]
        public decimal? DiasCredito { get; set; }
        [Column("saldo", TypeName = "numeric(5, 0)")]
        public decimal? Saldo { get; set; }
        [Column("id_fiscal")]
        [StringLength(18)]
        public string IdFiscal { get; set; }
        [Column("id_situacion", TypeName = "numeric(4, 0)")]
        public decimal? IdSituacion { get; set; }
        [Column("password")]
        [StringLength(15)]
        public string Password { get; set; }
        [Column("fecha_vig_carta", TypeName = "datetime")]
        public DateTime? FechaVigCarta { get; set; }
        [Column("limite_pago_elec", TypeName = "decimal(18, 0)")]
        public decimal? LimitePagoElec { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("cconsecutivo")]
        [StringLength(1)]
        public string Cconsecutivo { get; set; }
        [Column("grupo")]
        [StringLength(15)]
        public string Grupo { get; set; }
        [Column("almacen")]
        [StringLength(10)]
        public string Almacen { get; set; }
        [Column("observaciones", TypeName = "text")]
        public string Observaciones { get; set; }
        [Column("modulo")]
        public int? Modulo { get; set; }
        [Column("val_folio_solf")]
        [StringLength(1)]
        public string ValFolioSolf { get; set; }
        [Column("prod_x_cliente")]
        [StringLength(1)]
        public string ProdXCliente { get; set; }
        [Column("orden_nota")]
        [StringLength(1)]
        public string OrdenNota { get; set; }
        [Column("agrupar")]
        [StringLength(1)]
        public string Agrupar { get; set; }
        [Column("validar_producto")]
        [StringLength(1)]
        public string ValidarProducto { get; set; }
        [Column("id_referencia")]
        [StringLength(20)]
        public string IdReferencia { get; set; }
        [Column("notificacion")]
        [StringLength(1)]
        public string Notificacion { get; set; }
        [Column("no_parte_ped")]
        [StringLength(1)]
        public string NoPartePed { get; set; }
        [Column("automatic_smtp")]
        public bool? AutomaticSmtp { get; set; }
        [Column("protocol_smtp")]
        public bool? ProtocolSmtp { get; set; }
        [Column("authen_smtp")]
        public bool? AuthenSmtp { get; set; }
        [Column("server_smtp")]
        [StringLength(50)]
        public string ServerSmtp { get; set; }
        [Column("userid_smtp")]
        [StringLength(50)]
        public string UseridSmtp { get; set; }
        [Column("password_smtp")]
        [StringLength(50)]
        public string PasswordSmtp { get; set; }
        [Column("leyenda_notif_ent")]
        [StringLength(1)]
        public string LeyendaNotifEnt { get; set; }
        [Column("siempre_genera_shipper")]
        [StringLength(1)]
        public string SiempreGeneraShipper { get; set; }
        [Column("genera_proforma")]
        public bool GeneraProforma { get; set; }
        [Column("bd_intel")]
        [StringLength(1)]
        public string BdIntel { get; set; }
        [Column("observ_proveedor")]
        [StringLength(1)]
        public string ObservProveedor { get; set; }
        [Column("observ_factura")]
        [StringLength(1)]
        public string ObservFactura { get; set; }
        [Column("reporte_ped_txt")]
        [StringLength(1)]
        public string ReportePedTxt { get; set; }
        [Column("fecha_vig_conferido", TypeName = "datetime")]
        public DateTime? FechaVigConferido { get; set; }
        [Column("id_patente")]
        [StringLength(4)]
        public string IdPatente { get; set; }
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Column("seccion")]
        [StringLength(1)]
        public string Seccion { get; set; }
        [Column("crossdock")]
        [StringLength(1)]
        public string Crossdock { get; set; }
        [Column("obser_factura_parte")]
        [StringLength(1)]
        public string ObserFacturaParte { get; set; }
        [Column("firma_autografa")]
        [StringLength(500)]
        public string FirmaAutografa { get; set; }
        [Column("id_consec1")]
        [StringLength(6)]
        public string IdConsec1 { get; set; }
        [Column("id_consec2")]
        [StringLength(6)]
        public string IdConsec2 { get; set; }
        [Column("id_consec3")]
        [StringLength(6)]
        public string IdConsec3 { get; set; }
        [Column("id_consec4")]
        [StringLength(6)]
        public string IdConsec4 { get; set; }
        [Column("anexo24")]
        [StringLength(15)]
        public string Anexo24 { get; set; }
        [Column("path_a24")]
        [StringLength(255)]
        public string PathA24 { get; set; }
        [Column("agrupar_x_permisos")]
        [StringLength(1)]
        public string AgruparXPermisos { get; set; }
        [Column("pdf_unico")]
        [StringLength(1)]
        public string PdfUnico { get; set; }
        [Column("validar_productos_regimen")]
        [StringLength(1)]
        public string ValidarProductosRegimen { get; set; }
        [Column("contact_first_name")]
        [StringLength(13)]
        public string ContactFirstName { get; set; }
        [Column("contact_last_name")]
        [StringLength(20)]
        public string ContactLastName { get; set; }
        [Column("ultimate_consignee_type")]
        [StringLength(1)]
        public string UltimateConsigneeType { get; set; }
        [Column("val_sales_order")]
        [StringLength(1)]
        public string ValSalesOrder { get; set; }
        [Column("regla_8va")]
        [StringLength(1)]
        public string Regla8va { get; set; }
        [Column("plant_code")]
        public bool PlantCode { get; set; }
        [Column("localidad")]
        [StringLength(120)]
        public string Localidad { get; set; }
        [Column("autorizado_vulnerable")]
        [StringLength(1)]
        public string AutorizadoVulnerable { get; set; }
        [Column("vulnerable_inicio", TypeName = "datetime")]
        public DateTime? VulnerableInicio { get; set; }
        [Column("vulnerable_fin", TypeName = "datetime")]
        public DateTime? VulnerableFin { get; set; }
        [Column("vulnerable_dias_notifica")]
        public int? VulnerableDiasNotifica { get; set; }
        [Column("v1_sin_vehiculo")]
        [StringLength(1)]
        public string V1SinVehiculo { get; set; }
        [Column("validar_cove")]
        [StringLength(1)]
        public string ValidarCove { get; set; }
        [Column("menaje_de_casa")]
        [StringLength(1)]
        public string MenajeDeCasa { get; set; }
        [Column("agrupar_x_ident")]
        [StringLength(1)]
        public string AgruparXIdent { get; set; }
        [Column("agrupar_x_factprov")]
        [StringLength(1)]
        public string AgruparXFactprov { get; set; }
        [Column("cliente_facturacion")]
        [StringLength(6)]
        public string ClienteFacturacion { get; set; }
        [Column("ref_aux_mv_hc")]
        [StringLength(1)]
        public string RefAuxMvHc { get; set; }
        [Column("tarifa")]
        [StringLength(1)]
        public string Tarifa { get; set; }
        [Column("prefijo_cliente")]
        [StringLength(4)]
        public string PrefijoCliente { get; set; }
        [Column("pasar_producto_marca")]
        [StringLength(1)]
        public string PasarProductoMarca { get; set; }
        [Column("autorizar_pago_igi")]
        [StringLength(1)]
        public string AutorizarPagoIgi { get; set; }
        [Column("ft2")]
        [StringLength(1)]
        public string Ft2 { get; set; }
        [Column("prefijo_oc_or_re")]
        [StringLength(3)]
        public string PrefijoOcOrRe { get; set; }
        [Column("clasifica_po_um")]
        [StringLength(1)]
        public string ClasificaPoUm { get; set; }
        [Column("packlist_pendiente_fctra")]
        [StringLength(1)]
        public string PacklistPendienteFctra { get; set; }
        [Column("pasar_marca_modelo")]
        [StringLength(1)]
        public string PasarMarcaModelo { get; set; }
        [Column("Pasar_Series_Vins")]
        [StringLength(1)]
        public string PasarSeriesVins { get; set; }
        [Column("obs_partida_agrupar")]
        [StringLength(2)]
        public string ObsPartidaAgrupar { get; set; }
        [Column("obs_partida_noagrupar")]
        [StringLength(2)]
        public string ObsPartidaNoagrupar { get; set; }
        [Column("pasar_tx_destinatario")]
        [StringLength(1)]
        public string PasarTxDestinatario { get; set; }
        [Column("r1_copia_unidades")]
        [StringLength(1)]
        public string R1CopiaUnidades { get; set; }
        [Column("agrupar_x_producto")]
        [StringLength(1)]
        public string AgruparXProducto { get; set; }
        [Column("agrup_marc_mod_frac")]
        [StringLength(1)]
        public string AgrupMarcModFrac { get; set; }
        [Column("agrupar_x_desc")]
        [StringLength(1)]
        public string AgruparXDesc { get; set; }
        [Column("traficos_fast")]
        [StringLength(1)]
        public string TraficosFast { get; set; }
        [Column("sagar_colonia")]
        [StringLength(60)]
        public string SagarColonia { get; set; }
        [Column("fecha_ini_factor_seguro", TypeName = "datetime")]
        public DateTime? FechaIniFactorSeguro { get; set; }
        [Column("fecha_fin_factor_seguro", TypeName = "datetime")]
        public DateTime? FechaFinFactorSeguro { get; set; }
        [Column("factor_seguro", TypeName = "decimal(8, 6)")]
        public decimal? FactorSeguro { get; set; }
        [Column("aplica_factor_seguro")]
        [StringLength(1)]
        public string AplicaFactorSeguro { get; set; }
        [Column("po_series_nota_rev")]
        [StringLength(1)]
        public string PoSeriesNotaRev { get; set; }
        [Column("JWT")]
        [StringLength(200)]
        public string Jwt { get; set; }
        [Column("id_grupo_perfil", TypeName = "numeric(3, 0)")]
        public decimal? IdGrupoPerfil { get; set; }
        [Column("descripcion_grupo_perfil")]
        [StringLength(15)]
        public string DescripcionGrupoPerfil { get; set; }
        [Column("oficina_origen")]
        [StringLength(15)]
        public string OficinaOrigen { get; set; }
        [Column("logo")]
        [StringLength(30)]
        public string Logo { get; set; }

        [InverseProperty(nameof(FclienteEscape.IdClienteNavigation))]
        public virtual ICollection<FclienteEscape> FclienteEscapes { get; set; }
        [InverseProperty(nameof(Fescape.IdClienteNavigation))]
        public virtual ICollection<Fescape> Fescapes { get; set; }
        [InverseProperty(nameof(FrelClienteProveedor.IdClienteNavigation))]
        public virtual ICollection<FrelClienteProveedor> FrelClienteProveedors { get; set; }
    }
}
