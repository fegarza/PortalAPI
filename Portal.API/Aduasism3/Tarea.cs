using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("tareas")]
    [Index(nameof(Rowguid), Name = "index_419362596", IsUnique = true)]
    public partial class Tarea
    {
        [Key]
        [Column("tare_tarekey", TypeName = "decimal(18, 0)")]
        public decimal TareTarekey { get; set; }
        [Required]
        [Column("tare_idusuario")]
        [StringLength(6)]
        public string TareIdusuario { get; set; }
        [Column("tare_prioridad", TypeName = "numeric(18, 0)")]
        public decimal? TarePrioridad { get; set; }
        [Column("tare_descrip")]
        [StringLength(200)]
        public string TareDescrip { get; set; }
        [Column("tare_asignado")]
        [StringLength(6)]
        public string TareAsignado { get; set; }
        [Column("tare_fechaasig", TypeName = "datetime")]
        public DateTime? TareFechaasig { get; set; }
        [Column("tare_fechafin", TypeName = "datetime")]
        public DateTime? TareFechafin { get; set; }
        [Column("tare_status", TypeName = "numeric(18, 0)")]
        public decimal? TareStatus { get; set; }
        [Column("tare_observaciones")]
        [StringLength(100)]
        public string TareObservaciones { get; set; }
        [Column("fecha_real", TypeName = "datetime")]
        public DateTime? FechaReal { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
