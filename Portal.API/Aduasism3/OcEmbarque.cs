using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_embarque")]
    public partial class OcEmbarque
    {
        [Key]
        [Column("id_almacen")]
        [StringLength(8)]
        public string IdAlmacen { get; set; }
        [Key]
        [Column("id_embarque")]
        [StringLength(10)]
        public string IdEmbarque { get; set; }
        [Required]
        [Column("tipo_operacion")]
        [StringLength(1)]
        public string TipoOperacion { get; set; }
        [Required]
        [Column("id_tipo_embarque")]
        [StringLength(1)]
        public string IdTipoEmbarque { get; set; }
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Column("id_patente")]
        [StringLength(4)]
        public string IdPatente { get; set; }
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Column("seccion_aduana")]
        [StringLength(1)]
        public string SeccionAduana { get; set; }
        [Column("observaciones")]
        public string Observaciones { get; set; }
        [Column("fecha_embarque", TypeName = "datetime")]
        public DateTime? FechaEmbarque { get; set; }
        [Column("fecha_estimada_cruce", TypeName = "datetime")]
        public DateTime FechaEstimadaCruce { get; set; }
        [Column("fecha_cruce", TypeName = "datetime")]
        public DateTime? FechaCruce { get; set; }
        [Column("id_status_embarque")]
        public short IdStatusEmbarque { get; set; }
        [Column("requiere_surtido")]
        public bool RequiereSurtido { get; set; }
        [Column("escaneo_salida")]
        public bool EscaneoSalida { get; set; }
        [Column("inbond")]
        public bool Inbond { get; set; }
        [Column("inspeccion")]
        public bool Inspeccion { get; set; }
        [Column("hazmat")]
        public bool Hazmat { get; set; }
        [Column("exceso")]
        public bool Exceso { get; set; }
        [Column("peso_libras", TypeName = "decimal(14, 3)")]
        public decimal PesoLibras { get; set; }
        [Column("peso_kilos", TypeName = "decimal(14, 3)")]
        public decimal PesoKilos { get; set; }
        [Column("usuario_confirma")]
        [StringLength(6)]
        public string UsuarioConfirma { get; set; }
        [Column("fecha_confirma", TypeName = "datetime")]
        public DateTime? FechaConfirma { get; set; }
        [Column("usuario_carga")]
        [StringLength(6)]
        public string UsuarioCarga { get; set; }
        [Column("fecha_carga", TypeName = "datetime")]
        public DateTime? FechaCarga { get; set; }
        [Column("usuario_salida")]
        [StringLength(6)]
        public string UsuarioSalida { get; set; }
        [Column("fecha_salida", TypeName = "datetime")]
        public DateTime? FechaSalida { get; set; }
        [Column("usuario_cancela")]
        [StringLength(6)]
        public string UsuarioCancela { get; set; }
        [Column("fecha_cancela", TypeName = "datetime")]
        public DateTime? FechaCancela { get; set; }
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
        [Column("id_agencia_aduanal")]
        [StringLength(4)]
        public string IdAgenciaAduanal { get; set; }
        [Column("urgente")]
        public bool Urgente { get; set; }
        [Column("no_eei")]
        public bool NoEei { get; set; }
        [Column("overtime")]
        public bool Overtime { get; set; }
        [Column("danado")]
        public bool Danado { get; set; }
        [Column("codigo_salida")]
        [StringLength(20)]
        public string CodigoSalida { get; set; }
        [Column("observaciones_salida")]
        public string ObservacionesSalida { get; set; }
        [Column("codigo_vehiculo")]
        [StringLength(50)]
        public string CodigoVehiculo { get; set; }
        [Column("haz_mat")]
        public bool HazMat1 { get; set; }
        [Column("color")]
        [StringLength(1)]
        public string Color { get; set; }
        [Column("id_apoderado")]
        [StringLength(6)]
        public string IdApoderado { get; set; }
        [Column("referencia")]
        [StringLength(50)]
        public string Referencia { get; set; }
        [Column("referencia_aux")]
        [StringLength(50)]
        public string ReferenciaAux { get; set; }
        [Column("notificado")]
        public bool? Notificado { get; set; }
        [Column("id_ag_ad_ame")]
        [StringLength(6)]
        public string IdAgAdAme { get; set; }
        [Column("orden_carga")]
        public bool? OrdenCarga { get; set; }
        [Column("id_embarcador")]
        [StringLength(10)]
        public string IdEmbarcador { get; set; }
        [Column("nombre_embarcador")]
        [StringLength(120)]
        public string NombreEmbarcador { get; set; }
        [Column("manifiesto_carga")]
        public bool ManifiestoCarga { get; set; }
        [Column("observacion_cruce")]
        [StringLength(300)]
        public string ObservacionCruce { get; set; }
        [Column("no_cruzo_id")]
        public short? NoCruzoId { get; set; }
        [Column("ventana")]
        [StringLength(50)]
        public string Ventana { get; set; }
        [Column("carga_anticipada")]
        public bool? CargaAnticipada { get; set; }
        [Column("id_cubicaje")]
        public short? IdCubicaje { get; set; }
        [Column("comentarios")]
        [StringLength(100)]
        public string Comentarios { get; set; }
        [Column("alerta")]
        public bool? Alerta { get; set; }
        [Column("atendida")]
        public bool? Atendida { get; set; }

        [ForeignKey(nameof(IdAgAdAme))]
        [InverseProperty(nameof(FagAdAme.OcEmbarques))]
        public virtual FagAdAme IdAgAdAmeNavigation { get; set; }
    }
}
