using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("gg_mi_sistema")]
    public partial class GgMiSistema
    {
        [Key]
        [Column("usr_id")]
        [StringLength(8)]
        public string UsrId { get; set; }
        [Key]
        [Column("no_modulo")]
        public int NoModulo { get; set; }
        [Key]
        [Column("no_tarea")]
        public int NoTarea { get; set; }
        [Column("tipo_tarea")]
        public int? TipoTarea { get; set; }
    }
}
