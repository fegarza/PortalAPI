using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_solicitud_clasificacion")]
    public partial class OcSolicitudClasificacion
    {
        [Key]
        [Column("id_almacen")]
        [StringLength(8)]
        public string IdAlmacen { get; set; }
        [Key]
        [Column("numero_solicitud")]
        [StringLength(20)]
        public string NumeroSolicitud { get; set; }
        [Required]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Column("tipo_solicitud")]
        public short TipoSolicitud { get; set; }
        [Column("fecha_inicio", TypeName = "datetime")]
        public DateTime FechaInicio { get; set; }
        [Column("observaciones_almacen")]
        public string ObservacionesAlmacen { get; set; }
        [Column("observaciones_clasificacion")]
        public string ObservacionesClasificacion { get; set; }
        [Column("fecha_finalizacion", TypeName = "datetime")]
        public DateTime? FechaFinalizacion { get; set; }
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
    }
}
