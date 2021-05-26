using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("gg_autorizaciones_modulo")]
    public partial class GgAutorizacionesModulo
    {
        [Key]
        [Column("no_modulo")]
        public int NoModulo { get; set; }
        [Key]
        [Column("no_tarea")]
        public int NoTarea { get; set; }
        [Key]
        [Column("no_autorizacion")]
        public int NoAutorizacion { get; set; }
        [Column("descripcion")]
        [StringLength(100)]
        public string Descripcion { get; set; }
    }
}
