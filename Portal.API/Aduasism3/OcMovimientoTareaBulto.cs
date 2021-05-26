using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_movimiento_tarea_bulto")]
    public partial class OcMovimientoTareaBulto
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
        [Key]
        [Column("no_pallet")]
        public int NoPallet { get; set; }
        [Required]
        [Column("localizacion_origen")]
        [StringLength(15)]
        public string LocalizacionOrigen { get; set; }
        [Column("localizacion_destino")]
        [StringLength(15)]
        public string LocalizacionDestino { get; set; }
        [Column("tiempo_total", TypeName = "datetime")]
        public DateTime? TiempoTotal { get; set; }
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
        [Column("id_recibo")]
        [StringLength(10)]
        public string IdRecibo { get; set; }
        [Column("agrupacion")]
        [StringLength(15)]
        public string Agrupacion { get; set; }
    }
}
