using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("gg_tareas_modulos")]
    public partial class GgTareasModulo
    {
        [Key]
        [Column("no_modulo")]
        public int NoModulo { get; set; }
        [Key]
        [Column("no_tarea")]
        public int NoTarea { get; set; }
        [Key]
        [Column("tipo_tarea")]
        public int TipoTarea { get; set; }
        [Required]
        [Column("nombre")]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required]
        [Column("nombre_window")]
        [StringLength(50)]
        public string NombreWindow { get; set; }
        [Column("path_help")]
        [StringLength(100)]
        public string PathHelp { get; set; }
    }
}
