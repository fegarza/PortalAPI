using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_recibo")]
    [Index(nameof(IdAlmacen), nameof(ReciboMaster), Name = "IDX_DBA24_oc_recibo_id_almacen")]
    [Index(nameof(IdAlmacen), nameof(ReciboMaster), Name = "Indx_oc_recibo_id_almacen_recibo_master")]
    [Index(nameof(IdRecibo), Name = "UIoc_recibo", IsUnique = true)]
    public partial class OcRecibo
    {
        [Key]
        [Column("id_almacen")]
        [StringLength(8)]
        public string IdAlmacen { get; set; }
        [Key]
        [Column("id_recibo")]
        [StringLength(10)]
        public string IdRecibo { get; set; }
        [Column("fecha_recibo", TypeName = "datetime")]
        public DateTime FechaRecibo { get; set; }
        [Required]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Required]
        [Column("tipo_operacion")]
        [StringLength(1)]
        public string TipoOperacion { get; set; }
        [Required]
        [Column("id_proveedor")]
        [StringLength(10)]
        public string IdProveedor { get; set; }
        [Required]
        [Column("id_linea_fletera")]
        [StringLength(4)]
        public string IdLineaFletera { get; set; }
        [Required]
        [Column("tipo_transporte")]
        [StringLength(2)]
        public string TipoTransporte { get; set; }
        [Required]
        [Column("id_tipo_vehiculo")]
        [StringLength(2)]
        public string IdTipoVehiculo { get; set; }
        [Required]
        [Column("numero_vehiculo")]
        [StringLength(20)]
        public string NumeroVehiculo { get; set; }
        [Column("caja_directa")]
        public bool CajaDirecta { get; set; }
        [Column("orden_compra")]
        [StringLength(15)]
        public string OrdenCompra { get; set; }
        [Column("inbond")]
        public bool Inbond { get; set; }
        [Column("inbond_numero")]
        [StringLength(15)]
        public string InbondNumero { get; set; }
        [Column("fecha_inbond", TypeName = "date")]
        public DateTime? FechaInbond { get; set; }
        [Column("consolidado")]
        public bool Consolidado { get; set; }
        [Column("fecha_consolidado", TypeName = "datetime")]
        public DateTime? FechaConsolidado { get; set; }
        [Column("peso_libras", TypeName = "decimal(14, 3)")]
        public decimal PesoLibras { get; set; }
        [Column("peso_kilos", TypeName = "decimal(14, 3)")]
        public decimal PesoKilos { get; set; }
        [Column("bultos_entrada")]
        public int BultosEntrada { get; set; }
        [Column("observaciones")]
        [StringLength(1000)]
        public string Observaciones { get; set; }
        [Column("status_recibo")]
        public short StatusRecibo { get; set; }
        [Column("usuario_ingreso")]
        [StringLength(6)]
        public string UsuarioIngreso { get; set; }
        [Column("fecha_ingreso", TypeName = "datetime")]
        public DateTime? FechaIngreso { get; set; }
        [Column("usuario_modifica")]
        [StringLength(6)]
        public string UsuarioModifica { get; set; }
        [Column("fecha_modifica", TypeName = "datetime")]
        public DateTime? FechaModifica { get; set; }
        [Column("cancelado")]
        public bool Cancelado { get; set; }
        [Column("fecha_cancelacion", TypeName = "datetime")]
        public DateTime? FechaCancelacion { get; set; }
        [Column("padre")]
        public bool Padre { get; set; }
        [Column("hijo")]
        public bool Hijo { get; set; }
        [Column("recibo_master")]
        [StringLength(10)]
        public string ReciboMaster { get; set; }
        [Column("envio")]
        [StringLength(15)]
        public string Envio { get; set; }
        [Column("subdividido")]
        public bool Subdividido { get; set; }
        [Column("fecha_recibo_guia", TypeName = "datetime")]
        public DateTime FechaReciboGuia { get; set; }
        [Column("danado")]
        public bool Danado { get; set; }
        [Column("id_destino")]
        [StringLength(4)]
        public string IdDestino { get; set; }
        [Column("previo")]
        public bool Previo { get; set; }
        [Column("fecha_previo", TypeName = "datetime")]
        public DateTime? FechaPrevio { get; set; }
        [Column("usuario_previo")]
        [StringLength(6)]
        public string UsuarioPrevio { get; set; }
        [Column("etiquetar_asn")]
        public bool EtiquetarAsn { get; set; }
        [Column("fecha_cruce", TypeName = "datetime")]
        public DateTime? FechaCruce { get; set; }
        [Column("notificado")]
        public bool Notificado { get; set; }
        [Column("requiere_previo")]
        public bool RequierePrevio { get; set; }
        [Column("previo_finalizado")]
        public bool PrevioFinalizado { get; set; }
        [Column("fecha_entrega_programada", TypeName = "datetime")]
        public DateTime? FechaEntregaProgramada { get; set; }
        [Column("fecha_cruce_programada", TypeName = "datetime")]
        public DateTime? FechaCruceProgramada { get; set; }
        [Column("notificacion_documentos")]
        public bool NotificacionDocumentos { get; set; }
        [Column("embalaje_madera")]
        [StringLength(1)]
        public string EmbalajeMadera { get; set; }
        [Column("cumple_norma")]
        [StringLength(1)]
        public string CumpleNorma { get; set; }
        [Column("haz_mat")]
        public bool HazMat { get; set; }
        [Column("id_agencia")]
        [StringLength(6)]
        public string IdAgencia { get; set; }
        [Column("id_patente")]
        [StringLength(4)]
        public string IdPatente { get; set; }
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Column("seccion_aduana")]
        [StringLength(1)]
        public string SeccionAduana { get; set; }
        [Column("pedimento")]
        [StringLength(7)]
        public string Pedimento { get; set; }
        [Column("tipo_inbond")]
        [StringLength(2)]
        public string TipoInbond { get; set; }
        [Column("fecha_inbond_vencimiento", TypeName = "datetime")]
        public DateTime? FechaInbondVencimiento { get; set; }
        [Column("entry_number")]
        [StringLength(15)]
        public string EntryNumber { get; set; }
        [Column("urgente")]
        public bool Urgente { get; set; }
        [Column("referencia_cliente")]
        [StringLength(50)]
        public string ReferenciaCliente { get; set; }
        [Column("id_division_area")]
        [StringLength(4)]
        public string IdDivisionArea { get; set; }
        [Column("id_clase_carga")]
        public short? IdClaseCarga { get; set; }
        [Column("en_transito")]
        public bool EnTransito { get; set; }
        [Column("usuario_recepcion")]
        [StringLength(6)]
        public string UsuarioRecepcion { get; set; }
        [Column("fecha_recepcion", TypeName = "datetime")]
        public DateTime? FechaRecepcion { get; set; }
        [Column("id_plant_code")]
        [StringLength(6)]
        public string IdPlantCode { get; set; }
        [Column("fecha_recepction", TypeName = "datetime")]
        public DateTime? FechaRecepction { get; set; }
        [Column("hora_recibo_guia")]
        public TimeSpan? HoraReciboGuia { get; set; }
        [Column("discrepancia")]
        public bool? Discrepancia { get; set; }
        [Column("requiere_previo_recibo")]
        public bool? RequierePrevioRecibo { get; set; }
        [Column("pedimento_anticipado")]
        public bool? PedimentoAnticipado { get; set; }
        [Column("fecha_caducidad", TypeName = "datetime")]
        public DateTime? FechaCaducidad { get; set; }
        [Column("lote")]
        [StringLength(50)]
        public string Lote { get; set; }
        [Column("fecha_notificacion_danos", TypeName = "datetime")]
        public DateTime? FechaNotificacionDanos { get; set; }
        [Column("notificado_previo")]
        public bool NotificadoPrevio { get; set; }
        [Column("subdividido_factura")]
        public short? SubdivididoFactura { get; set; }
        [Column("espacio_caja", TypeName = "decimal(14, 3)")]
        public decimal? EspacioCaja { get; set; }
        [Column("id_embarcador")]
        [StringLength(10)]
        public string IdEmbarcador { get; set; }
        [Column("nombre_embarcador")]
        [StringLength(120)]
        public string NombreEmbarcador { get; set; }
        [Column("transbordo")]
        public bool? Transbordo { get; set; }
        [Column("carga_masiva")]
        public bool? CargaMasiva { get; set; }
        [Column("id_tipo_embarque_arribo")]
        [StringLength(4)]
        public string IdTipoEmbarqueArribo { get; set; }
        [Column("pro_number")]
        [StringLength(35)]
        public string ProNumber { get; set; }
        [Column("tipo_distribucion")]
        public short? TipoDistribucion { get; set; }
        [Column("double_space", TypeName = "decimal(14, 3)")]
        public decimal? DoubleSpace { get; set; }
        [Column("booking_date", TypeName = "datetime")]
        public DateTime? BookingDate { get; set; }
        [Column("booking_number")]
        [StringLength(35)]
        public string BookingNumber { get; set; }
        [Column("fecha_finalizacion_carga", TypeName = "datetime")]
        public DateTime? FechaFinalizacionCarga { get; set; }
        [Column("hora_finalizacion_carga")]
        public TimeSpan? HoraFinalizacionCarga { get; set; }
        [Column("fecha_llegada_alden", TypeName = "datetime")]
        public DateTime? FechaLlegadaAlden { get; set; }
        [Column("fecha_descarga", TypeName = "datetime")]
        public DateTime? FechaDescarga { get; set; }
    }
}
