using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_movimiento")]
    public partial class OcMovimiento
    {
        [Key]
        [Column("id_almacen")]
        [StringLength(8)]
        public string IdAlmacen { get; set; }
        [Key]
        [Column("id_movimiento")]
        public int IdMovimiento { get; set; }
        [Column("status_movimiento")]
        public short StatusMovimiento { get; set; }
        [Column("tipo_solicitud")]
        public short TipoSolicitud { get; set; }
        [Required]
        [Column("numero_solicitud")]
        [StringLength(10)]
        public string NumeroSolicitud { get; set; }
        [Column("fecha_inicio", TypeName = "datetime")]
        public DateTime? FechaInicio { get; set; }
        [Column("fecha_fin", TypeName = "datetime")]
        public DateTime? FechaFin { get; set; }
        [Column("tiempo_total", TypeName = "datetime")]
        public DateTime? TiempoTotal { get; set; }
        [Column("total_bultos")]
        public int TotalBultos { get; set; }
        [Column("bultos_depositados")]
        public int BultosDepositados { get; set; }
        [Column("total_tareas")]
        public int TotalTareas { get; set; }
        [Column("tareas_en_proceso")]
        public int TareasEnProceso { get; set; }
        [Column("codigo_solicitud")]
        [StringLength(250)]
        public string CodigoSolicitud { get; set; }
        [Column("bloqueado")]
        public bool Bloqueado { get; set; }
        [Column("id_motivo")]
        public short? IdMotivo { get; set; }
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
