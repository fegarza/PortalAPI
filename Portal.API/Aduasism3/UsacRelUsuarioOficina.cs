using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("usac_rel_usuario_oficina")]
    public partial class UsacRelUsuarioOficina
    {
        [Key]
        [Column("id_usuario")]
        [StringLength(6)]
        public string IdUsuario { get; set; }
        [Key]
        [Column("id_oficina")]
        public int IdOficina { get; set; }
    }
}
