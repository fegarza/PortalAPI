using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("gg_mensajes")]
    public partial class GgMensaje
    {
        [Key]
        [Column("no_modulo")]
        public int NoModulo { get; set; }
        [Key]
        [Column("no_mensaje")]
        public int NoMensaje { get; set; }
        [Required]
        [Column("mensaje")]
        [StringLength(150)]
        public string Mensaje { get; set; }
    }
}
