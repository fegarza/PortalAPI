using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_movimiento_tarea")]
    public partial class OcMovimientoTarea
    {
        [Key]
        [Column("id_almacen")]
        [StringLength(8)]
        public string IdAlmacen { get; set; }
        [Key]
        [Column("id_movimiento")]
        public int IdMovimiento { get; set; }
        [Key]
        [Column("id_tarea")]
        public int IdTarea { get; set; }
        [Column("status_tarea")]
        public short StatusTarea { get; set; }
        [Column("fecha_inicio", TypeName = "datetime")]
        public DateTime FechaInicio { get; set; }
        [Column("fecha_fin", TypeName = "datetime")]
        public DateTime? FechaFin { get; set; }
        [Column("tiempo_total", TypeName = "datetime")]
        public DateTime? TiempoTotal { get; set; }
        [Column("total_bultos")]
        public int TotalBultos { get; set; }
        [Column("movil")]
        [StringLength(15)]
        public string Movil { get; set; }
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
