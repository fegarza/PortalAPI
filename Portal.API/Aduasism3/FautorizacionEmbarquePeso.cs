using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fautorizacion_embarque_peso")]
    public partial class FautorizacionEmbarquePeso
    {
        [Key]
        [Column("id_embarque")]
        [StringLength(10)]
        public string IdEmbarque { get; set; }
        [Column("fecha_autoriza", TypeName = "datetime")]
        public DateTime? FechaAutoriza { get; set; }
        [Column("id_usuario_autoriza")]
        [StringLength(6)]
        public string IdUsuarioAutoriza { get; set; }
    }
}
