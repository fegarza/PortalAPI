using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ct_tipo_poliza_contable")]
    public partial class CtTipoPolizaContable
    {
        [Key]
        [Column("cve_poliza", TypeName = "decimal(4, 0)")]
        public decimal CvePoliza { get; set; }
        [Required]
        [Column("descr_poliza")]
        [StringLength(60)]
        public string DescrPoliza { get; set; }
        [Required]
        [Column("tipo_poliza")]
        [StringLength(1)]
        public string TipoPoliza { get; set; }
        [Required]
        [Column("prefijo")]
        [StringLength(4)]
        public string Prefijo { get; set; }
        [Column("fecha_inicio_poliza", TypeName = "datetime")]
        public DateTime FechaInicioPoliza { get; set; }
        [Column("fecha_final_poliza", TypeName = "datetime")]
        public DateTime FechaFinalPoliza { get; set; }
        [Required]
        [Column("status_poliza")]
        [StringLength(1)]
        public string StatusPoliza { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime? FechaRegistro { get; set; }
        [Column("usuario")]
        [StringLength(8)]
        public string Usuario { get; set; }
        [Column("numempresa")]
        public int? Numempresa { get; set; }
    }
}
