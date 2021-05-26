using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fautoriza_traficos")]
    public partial class FautorizaTrafico
    {
        [Key]
        [Column("id_trafico")]
        [StringLength(10)]
        public string IdTrafico { get; set; }
        [Column("fecha_autorizacion", TypeName = "datetime")]
        public DateTime? FechaAutorizacion { get; set; }
        [Column("id_usuario_autoriza")]
        [StringLength(6)]
        public string IdUsuarioAutoriza { get; set; }
    }
}
