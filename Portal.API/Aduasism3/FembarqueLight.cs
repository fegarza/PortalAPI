using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fembarque_light")]
    public partial class FembarqueLight
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
        [Column("id_tipo_pedimento")]
        [StringLength(2)]
        public string IdTipoPedimento { get; set; }
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
        [Column("observaciones_rel_carga", TypeName = "text")]
        public string ObservacionesRelCarga { get; set; }
        [Column("observaciones_delivery_order", TypeName = "text")]
        public string ObservacionesDeliveryOrder { get; set; }
        [Column("cruza_expd")]
        [StringLength(1)]
        public string CruzaExpd { get; set; }
        [Column("numero_prefile")]
        [StringLength(14)]
        public string NumeroPrefile { get; set; }
        [Column("estado_placas")]
        [StringLength(2)]
        public string EstadoPlacas { get; set; }
        [Column("fecha_segundo_reconocimiento", TypeName = "datetime")]
        public DateTime? FechaSegundoReconocimiento { get; set; }
        [Column("cve_entrada_aduana")]
        [StringLength(1)]
        public string CveEntradaAduana { get; set; }
        [Column("cve_segundo_reconocimiento")]
        [StringLength(1)]
        public string CveSegundoReconocimiento { get; set; }
        [Column("fecha_aduana_entrada", TypeName = "datetime")]
        public DateTime? FechaAduanaEntrada { get; set; }
        [Column("fecha_aduana_salida", TypeName = "datetime")]
        public DateTime? FechaAduanaSalida { get; set; }
    }
}
