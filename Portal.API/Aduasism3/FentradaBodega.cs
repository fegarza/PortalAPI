using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fentrada_bodega")]
    [Index(nameof(Rowguid), Name = "index_1934629935", IsUnique = true)]
    public partial class FentradaBodega
    {
        public FentradaBodega()
        {
            FbultoDetalles = new HashSet<FbultoDetalle>();
            FbultoHistoricos = new HashSet<FbultoHistorico>();
        }

        [Required]
        [Column("id_bodega")]
        [StringLength(8)]
        public string IdBodega { get; set; }
        [Key]
        [Column("id_entrada")]
        [StringLength(10)]
        public string IdEntrada { get; set; }
        [Column("fecha_entrada", TypeName = "datetime")]
        public DateTime FechaEntrada { get; set; }
        [Required]
        [Column("id_usuario_recibe")]
        [StringLength(6)]
        public string IdUsuarioRecibe { get; set; }
        [Required]
        [Column("marca_mcia")]
        [StringLength(20)]
        public string MarcaMcia { get; set; }
        [Required]
        [Column("cve_tipo_opn")]
        [StringLength(1)]
        public string CveTipoOpn { get; set; }
        [Column("guia_flete")]
        [StringLength(35)]
        public string GuiaFlete { get; set; }
        [Column("fecha_guia", TypeName = "datetime")]
        public DateTime FechaGuia { get; set; }
        [Required]
        [Column("id_tipo_vehiculo")]
        [StringLength(2)]
        public string IdTipoVehiculo { get; set; }
        [Required]
        [Column("num_vehiculo")]
        [StringLength(20)]
        public string NumVehiculo { get; set; }
        [Column("cve_flete_pagado", TypeName = "numeric(1, 0)")]
        public decimal CveFletePagado { get; set; }
        [Column("importe_flete", TypeName = "numeric(10, 2)")]
        public decimal ImporteFlete { get; set; }
        [Column("poliza_flete")]
        [StringLength(11)]
        public string PolizaFlete { get; set; }
        [Required]
        [Column("id_linea_fletera")]
        [StringLength(4)]
        public string IdLineaFletera { get; set; }
        [Required]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Required]
        [Column("id_proveedor")]
        [StringLength(6)]
        public string IdProveedor { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime FechaRegistro { get; set; }
        [Required]
        [Column("id_usuario_registro")]
        [StringLength(6)]
        public string IdUsuarioRegistro { get; set; }
        [Column("fecha_ultmodif", TypeName = "datetime")]
        public DateTime FechaUltmodif { get; set; }
        [Required]
        [Column("id_usuario_ult_modif")]
        [StringLength(6)]
        public string IdUsuarioUltModif { get; set; }
        [Required]
        [Column("situacion")]
        [StringLength(1)]
        public string Situacion { get; set; }
        [Required]
        [Column("observaciones", TypeName = "text")]
        public string Observaciones { get; set; }
        [Column("in_bond")]
        [StringLength(1)]
        public string InBond { get; set; }
        [Column("directa")]
        [StringLength(1)]
        public string Directa { get; set; }
        [Column("seccion_entrada")]
        [StringLength(15)]
        public string SeccionEntrada { get; set; }
        [Column("peso_kgs", TypeName = "numeric(14, 3)")]
        public decimal? PesoKgs { get; set; }
        [Column("peso_libras", TypeName = "numeric(14, 3)")]
        public decimal? PesoLibras { get; set; }
        [Column("servicio_linea")]
        [StringLength(3)]
        public string ServicioLinea { get; set; }
        [Column("dias_libres", TypeName = "numeric(2, 0)")]
        public decimal? DiasLibres { get; set; }
        [Column("importe_demora_dia", TypeName = "numeric(9, 2)")]
        public decimal? ImporteDemoraDia { get; set; }
        [Column("id_ag_ad_ame")]
        [StringLength(6)]
        public string IdAgAdAme { get; set; }
        [Column("inbond_numero")]
        [StringLength(15)]
        public string InbondNumero { get; set; }
        [Column("fecha_salida", TypeName = "datetime")]
        public DateTime? FechaSalida { get; set; }
        [Column("pre_file")]
        [StringLength(20)]
        public string PreFile { get; set; }
        [Column("cve_tipo_transporte")]
        [StringLength(2)]
        public string CveTipoTransporte { get; set; }
        [Column("id_moneda_flete")]
        [StringLength(4)]
        public string IdMonedaFlete { get; set; }
        [Column("factor_flete", TypeName = "numeric(10, 8)")]
        public decimal? FactorFlete { get; set; }
        [Column("fecha_inbond", TypeName = "datetime")]
        public DateTime? FechaInbond { get; set; }
        [Column("URGENTE")]
        [StringLength(1)]
        public string Urgente { get; set; }
        [Column("fecha_venc_inbond", TypeName = "datetime")]
        public DateTime? FechaVencInbond { get; set; }
        [Column("control_caja", TypeName = "numeric(6, 0)")]
        public decimal? ControlCaja { get; set; }
        [Column("ref_ups")]
        [StringLength(15)]
        public string RefUps { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("fecha_salida_origen", TypeName = "datetime")]
        public DateTime? FechaSalidaOrigen { get; set; }
        [Column("id_consignatario")]
        [StringLength(10)]
        public string IdConsignatario { get; set; }
        [Column("obs_entrada1")]
        [StringLength(30)]
        public string ObsEntrada1 { get; set; }
        [Column("obs_entrada2")]
        [StringLength(30)]
        public string ObsEntrada2 { get; set; }
        [Column("valor_guia_h", TypeName = "decimal(8, 0)")]
        public decimal? ValorGuiaH { get; set; }
        [Column("id_orden")]
        [StringLength(15)]
        public string IdOrden { get; set; }
        [Column("folio_entrada")]
        [StringLength(10)]
        public string FolioEntrada { get; set; }
        [Column("total_importe_demora")]
        public double? TotalImporteDemora { get; set; }
        [Column("demora")]
        public short? Demora { get; set; }
        [Column("fecha_limite", TypeName = "datetime")]
        public DateTime? FechaLimite { get; set; }
        [Column("cantidad_bultos")]
        public int? CantidadBultos { get; set; }
        [Column("cantidad_pallets")]
        public int? CantidadPallets { get; set; }
        [Column("peso_bultos", TypeName = "numeric(14, 3)")]
        public decimal? PesoBultos { get; set; }
        [Column("status_movimiento")]
        public byte? StatusMovimiento { get; set; }
        [Column("total_bultos")]
        public int? TotalBultos { get; set; }
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Column("seccion")]
        [StringLength(1)]
        public string Seccion { get; set; }
        [Column("id_patente")]
        [StringLength(4)]
        public string IdPatente { get; set; }
        [Column("pedimento")]
        [StringLength(7)]
        public string Pedimento { get; set; }
        [Column("vehiculo_salida")]
        [StringLength(20)]
        public string VehiculoSalida { get; set; }
        [Column("sello_salida")]
        [StringLength(10)]
        public string SelloSalida { get; set; }
        [Column("sello_salida2")]
        [StringLength(10)]
        public string SelloSalida2 { get; set; }
        [Column("placas_salida")]
        [StringLength(20)]
        public string PlacasSalida { get; set; }
        [Column("entry_number")]
        [StringLength(15)]
        public string EntryNumber { get; set; }
        [Column("emb_madera")]
        [StringLength(1)]
        public string EmbMadera { get; set; }
        [Column("cumple_norma")]
        [StringLength(1)]
        public string CumpleNorma { get; set; }
        [Column("notificado")]
        [StringLength(1)]
        public string Notificado { get; set; }
        [Column("no_aviso")]
        [StringLength(1)]
        public string NoAviso { get; set; }
        [Column("tipo_inbond")]
        [StringLength(2)]
        public string TipoInbond { get; set; }
        [Column("fecha_revalidacion", TypeName = "smalldatetime")]
        public DateTime? FechaRevalidacion { get; set; }
        [Column("fecha_previo", TypeName = "smalldatetime")]
        public DateTime? FechaPrevio { get; set; }
        [Column("fecha_discrepancias", TypeName = "smalldatetime")]
        public DateTime? FechaDiscrepancias { get; set; }
        [Column("fecha_solicitud_impuestos", TypeName = "smalldatetime")]
        public DateTime? FechaSolicitudImpuestos { get; set; }
        [Column("placa_origen")]
        [StringLength(3)]
        public string PlacaOrigen { get; set; }
        [Column("contenedor")]
        [StringLength(20)]
        public string Contenedor { get; set; }
        [Column("discrepancias_dp")]
        [StringLength(30)]
        public string DiscrepanciasDp { get; set; }
        [Column("conocimiento_maritimo")]
        [StringLength(30)]
        public string ConocimientoMaritimo { get; set; }
        [Column("certificado_orig")]
        [StringLength(15)]
        public string CertificadoOrig { get; set; }
        [Column("anticipo", TypeName = "numeric(12, 2)")]
        public decimal? Anticipo { get; set; }
        [Column("fecha_anticipo", TypeName = "datetime")]
        public DateTime? FechaAnticipo { get; set; }
        [Column("tipo_docto")]
        [StringLength(15)]
        public string TipoDocto { get; set; }
        [Column("naviera")]
        [StringLength(20)]
        public string Naviera { get; set; }
        [Column("buque")]
        [StringLength(50)]
        public string Buque { get; set; }
        [Column("fecha_aprox_arribo", TypeName = "datetime")]
        public DateTime? FechaAproxArribo { get; set; }
        [Column("fecha_fondeo", TypeName = "datetime")]
        public DateTime? FechaFondeo { get; set; }
        [Column("fecha_real_arribo", TypeName = "datetime")]
        public DateTime? FechaRealArribo { get; set; }
        [Column("fecha_solicitud_transp", TypeName = "datetime")]
        public DateTime? FechaSolicitudTransp { get; set; }
        [Column("fecha_regreso_cont_vacio", TypeName = "datetime")]
        public DateTime? FechaRegresoContVacio { get; set; }
        [Column("fecha_progr_previo", TypeName = "datetime")]
        public DateTime? FechaProgrPrevio { get; set; }
        [Column("fecha_desp_previo", TypeName = "datetime")]
        public DateTime? FechaDespPrevio { get; set; }
        [Column("fecha_atraque", TypeName = "datetime")]
        public DateTime? FechaAtraque { get; set; }
        [Column("booking")]
        [StringLength(10)]
        public string Booking { get; set; }
        [Column("puerto_destino")]
        [StringLength(20)]
        public string PuertoDestino { get; set; }
        [Column("fecha_cierre_doc", TypeName = "datetime")]
        public DateTime? FechaCierreDoc { get; set; }
        [Column("fecha_doc", TypeName = "datetime")]
        public DateTime? FechaDoc { get; set; }
        [Column("fecha_entrega_naviera", TypeName = "datetime")]
        public DateTime? FechaEntregaNaviera { get; set; }
        [Column("fecha_reexpidio", TypeName = "datetime")]
        public DateTime? FechaReexpidio { get; set; }
        [Column("status_clas")]
        [StringLength(1)]
        public string StatusClas { get; set; }
        [Column("clasificacion_terminada", TypeName = "datetime")]
        public DateTime? ClasificacionTerminada { get; set; }
        [Column("id_regimen_entrada")]
        [StringLength(2)]
        public string IdRegimenEntrada { get; set; }
        [Column("haz_mat")]
        [StringLength(1)]
        public string HazMat { get; set; }
        [Column("pais_procedencia")]
        [StringLength(4)]
        public string PaisProcedencia { get; set; }
        [Column("ciudad_procedencia")]
        [StringLength(4)]
        public string CiudadProcedencia { get; set; }
        [Column("estado_procedencia")]
        [StringLength(4)]
        public string EstadoProcedencia { get; set; }

        [InverseProperty(nameof(FbultoDetalle.IdEntradaNavigation))]
        public virtual ICollection<FbultoDetalle> FbultoDetalles { get; set; }
        [InverseProperty(nameof(FbultoHistorico.IdEntradaNavigation))]
        public virtual ICollection<FbultoHistorico> FbultoHistoricos { get; set; }
    }
}
