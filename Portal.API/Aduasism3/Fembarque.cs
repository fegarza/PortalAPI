using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fembarque")]
    [Index(nameof(Rowguid), Name = "index_869578136", IsUnique = true)]
    public partial class Fembarque
    {
        [Key]
        [Column("id_embarque")]
        [StringLength(10)]
        public string IdEmbarque { get; set; }
        [Required]
        [Column("cve_tipo_operacion")]
        [StringLength(1)]
        public string CveTipoOperacion { get; set; }
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Column("seccion_aduana")]
        [StringLength(1)]
        public string SeccionAduana { get; set; }
        [Required]
        [Column("cve_tipo_embarque")]
        [StringLength(1)]
        public string CveTipoEmbarque { get; set; }
        [Column("id_patente")]
        [StringLength(4)]
        public string IdPatente { get; set; }
        [Column("id_apoderado")]
        [StringLength(6)]
        public string IdApoderado { get; set; }
        [Column("fecha_prog_cruce", TypeName = "datetime")]
        public DateTime? FechaProgCruce { get; set; }
        [Column("fecha_real_cruce", TypeName = "datetime")]
        public DateTime? FechaRealCruce { get; set; }
        [Column("id_usuario")]
        [StringLength(6)]
        public string IdUsuario { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime? FechaRegistro { get; set; }
        [Column("id_usuario_ultmodif")]
        [StringLength(6)]
        public string IdUsuarioUltmodif { get; set; }
        [Column("fecha_ultmodif", TypeName = "datetime")]
        public DateTime? FechaUltmodif { get; set; }
        [Column("razon_social")]
        [StringLength(40)]
        public string RazonSocial { get; set; }
        [Column("cve_entrada_aduana")]
        [StringLength(1)]
        public string CveEntradaAduana { get; set; }
        [Column("id_tipo_pedimento")]
        [StringLength(2)]
        public string IdTipoPedimento { get; set; }
        [Column("fecha_segundo_reconocimiento", TypeName = "datetime")]
        public DateTime? FechaSegundoReconocimiento { get; set; }
        [Column("cve_segundo_reconocimiento")]
        [StringLength(1)]
        public string CveSegundoReconocimiento { get; set; }
        [Column("fecha_aduana_salida", TypeName = "datetime")]
        public DateTime? FechaAduanaSalida { get; set; }
        [Column("observaciones", TypeName = "text")]
        public string Observaciones { get; set; }
        [Column("fecha_aduana_entrada", TypeName = "datetime")]
        public DateTime? FechaAduanaEntrada { get; set; }
        [Column("secuencial", TypeName = "numeric(5, 0)")]
        public decimal? Secuencial { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("fecha_salida_origen", TypeName = "datetime")]
        public DateTime? FechaSalidaOrigen { get; set; }
        [Column("fecha_llegada_nld", TypeName = "datetime")]
        public DateTime? FechaLlegadaNld { get; set; }
        [Column("fecha_salida_bodega", TypeName = "datetime")]
        public DateTime? FechaSalidaBodega { get; set; }
        [Column("fecha_garita_int", TypeName = "datetime")]
        public DateTime? FechaGaritaInt { get; set; }
        [Column("fecha_entrega_carrier", TypeName = "datetime")]
        public DateTime? FechaEntregaCarrier { get; set; }
        [Column("sello1")]
        [StringLength(12)]
        public string Sello1 { get; set; }
        [Column("sello2")]
        [StringLength(12)]
        public string Sello2 { get; set; }
        [Column("imagen")]
        [StringLength(100)]
        public string Imagen { get; set; }
        [Column("imagen_salida")]
        [StringLength(100)]
        public string ImagenSalida { get; set; }
        [Column("status_embarque")]
        public short? StatusEmbarque { get; set; }
        [Column("urgente")]
        [StringLength(1)]
        public string Urgente { get; set; }
        [Column("id_bodega")]
        [StringLength(8)]
        public string IdBodega { get; set; }
        [Column("crossdock")]
        [StringLength(1)]
        public string Crossdock { get; set; }
        [Column("proteger_embarque")]
        [StringLength(1)]
        public string ProtegerEmbarque { get; set; }
        [Column("id_issue")]
        [StringLength(10)]
        public string IdIssue { get; set; }
        [Column("tiene_issue")]
        [StringLength(1)]
        public string TieneIssue { get; set; }
        [Column("issue_comments")]
        [StringLength(250)]
        public string IssueComments { get; set; }
        [Column("inbond")]
        [StringLength(1)]
        public string Inbond { get; set; }
        [Column("inspeccion")]
        [StringLength(1)]
        public string Inspeccion { get; set; }
        [Column("no_eei")]
        [StringLength(1)]
        public string NoEei { get; set; }
        [Column("hazmat")]
        [StringLength(1)]
        public string Hazmat { get; set; }
        [Column("pedimento_listo", TypeName = "datetime")]
        public DateTime? PedimentoListo { get; set; }
        [Column("recolectar_carga", TypeName = "datetime")]
        public DateTime? RecolectarCarga { get; set; }
        [Column("pedimento_listo_notificado")]
        [StringLength(1)]
        public string PedimentoListoNotificado { get; set; }
        [Column("recolectar_carga_notificado")]
        [StringLength(1)]
        public string RecolectarCargaNotificado { get; set; }
        [Column("exceso")]
        [StringLength(1)]
        public string Exceso { get; set; }
        [Column("overtime")]
        [StringLength(1)]
        public string Overtime { get; set; }
        [Column("portal")]
        [StringLength(1)]
        public string Portal { get; set; }
        [Column("actualizacion_doda")]
        public bool? ActualizacionDoda { get; set; }
    }
}
