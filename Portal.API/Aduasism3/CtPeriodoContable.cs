using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ct_periodo_contable")]
    public partial class CtPeriodoContable
    {
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Key]
        [Column("cve_periodo", TypeName = "decimal(6, 0)")]
        public decimal CvePeriodo { get; set; }
        [Required]
        [Column("tipo_periodo")]
        [StringLength(1)]
        public string TipoPeriodo { get; set; }
        [Column("fecha_inicio", TypeName = "datetime")]
        public DateTime FechaInicio { get; set; }
        [Column("fecha_terminacion", TypeName = "datetime")]
        public DateTime FechaTerminacion { get; set; }
        [Required]
        [Column("status_periodo")]
        [StringLength(1)]
        public string StatusPeriodo { get; set; }
    }
}
