using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_actividad_clasificacion")]
    public partial class OcActividadClasificacion
    {
        [Required]
        [Column("usuario")]
        [StringLength(10)]
        public string Usuario { get; set; }
        [Key]
        [Column("id_actividad")]
        public int IdActividad { get; set; }
        [Key]
        [Column("id_tarea")]
        [StringLength(18)]
        public string IdTarea { get; set; }
        [Column("fecha", TypeName = "date")]
        public DateTime Fecha { get; set; }
        [Column("hora_inicio", TypeName = "time(0)")]
        public TimeSpan? HoraInicio { get; set; }
        [Column("hora_fin", TypeName = "time(0)")]
        public TimeSpan? HoraFin { get; set; }
        [Column("duracion", TypeName = "time(0)")]
        public TimeSpan Duracion { get; set; }
        [Column("observaciones")]
        [StringLength(250)]
        public string Observaciones { get; set; }
        [Required]
        [Column("usuario_inserta")]
        [StringLength(10)]
        public string UsuarioInserta { get; set; }
        [Column("fecha_inserta", TypeName = "datetime")]
        public DateTime FechaInserta { get; set; }
        [Column("usuario_modifica")]
        [StringLength(10)]
        public string UsuarioModifica { get; set; }
        [Column("fecha_modifica", TypeName = "datetime")]
        public DateTime? FechaModifica { get; set; }
        [Column("id_oficina")]
        public short? IdOficina { get; set; }
        [Column("descripcion")]
        [StringLength(1000)]
        public string Descripcion { get; set; }
        [Required]
        [Column("id_almacen")]
        [StringLength(8)]
        public string IdAlmacen { get; set; }
    }
}
