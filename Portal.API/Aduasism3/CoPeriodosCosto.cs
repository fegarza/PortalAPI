using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("co_periodos_costos")]
    public partial class CoPeriodosCosto
    {
        [Key]
        [Column("cve_periodo", TypeName = "numeric(6, 0)")]
        public decimal CvePeriodo { get; set; }
        [Column("fecha_inicio", TypeName = "datetime")]
        public DateTime FechaInicio { get; set; }
        [Column("fecha_final", TypeName = "datetime")]
        public DateTime FechaFinal { get; set; }
        [Required]
        [Column("status_periodo")]
        [StringLength(1)]
        public string StatusPeriodo { get; set; }
    }
}
