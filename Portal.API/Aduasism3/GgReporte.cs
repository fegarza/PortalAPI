using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("gg_reportes")]
    public partial class GgReporte
    {
        [Key]
        [Column("no_modulo")]
        public int NoModulo { get; set; }
        [Key]
        [Column("no_tarea")]
        public int NoTarea { get; set; }
        [Key]
        [Column("no_reporte")]
        public int NoReporte { get; set; }
        [Required]
        [Column("nombre")]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Column("nombre_window")]
        [StringLength(50)]
        public string NombreWindow { get; set; }
        [Column("path_help")]
        [StringLength(50)]
        public string PathHelp { get; set; }
        [Column("alias_sica")]
        [StringLength(50)]
        public string AliasSica { get; set; }
        [Column("dw_name")]
        [StringLength(50)]
        public string DwName { get; set; }
        [Column("tipo_reporte")]
        public int? TipoReporte { get; set; }
        [Column("mascara")]
        public int? Mascara { get; set; }
    }
}
