using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("web_reporte_notificacion_parametro")]
    public partial class WebReporteNotificacionParametro
    {
        [Key]
        [Column("id_aplicacion")]
        public short IdAplicacion { get; set; }
        [Key]
        [Column("id_reporte")]
        public short IdReporte { get; set; }
        [Key]
        [Column("secuencial")]
        public short Secuencial { get; set; }
        [Key]
        [Column("secuencial_parametro")]
        public short SecuencialParametro { get; set; }
        [Required]
        [Column("id_parametro")]
        [StringLength(50)]
        public string IdParametro { get; set; }
        [Column("id_comparativo")]
        public short IdComparativo { get; set; }
        [Required]
        [Column("valor")]
        [StringLength(255)]
        public string Valor { get; set; }
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
