using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("wr_registro_modulo_rol")]
    public partial class WrRegistroModuloRol
    {
        [Required]
        [Column("usuario_modifica")]
        [StringLength(6)]
        public string UsuarioModifica { get; set; }
        [Column("fecha_modifica", TypeName = "datetime")]
        public DateTime FechaModifica { get; set; }
        [Required]
        [Column("modifica_modulo_rol")]
        [StringLength(250)]
        public string ModificaModuloRol { get; set; }
    }
}
