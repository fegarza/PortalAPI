using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("tareas_security")]
    public partial class TareasSecurity
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
        [Key]
        [Column("usr_id")]
        [StringLength(8)]
        public string UsrId { get; set; }
        [Column("write")]
        [StringLength(1)]
        public string Write { get; set; }
        [Column("erase")]
        [StringLength(1)]
        public string Erase { get; set; }
        [Column("consult")]
        [StringLength(1)]
        public string Consult { get; set; }
        [Column("report")]
        [StringLength(1)]
        public string Report { get; set; }
    }
}
