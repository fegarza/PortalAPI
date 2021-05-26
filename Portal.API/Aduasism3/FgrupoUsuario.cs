using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fgrupo_usuario")]
    public partial class FgrupoUsuario
    {
        [Key]
        [Column("id_grupo")]
        [StringLength(10)]
        public string IdGrupo { get; set; }
        [Key]
        [Column("id_usuario")]
        [StringLength(6)]
        public string IdUsuario { get; set; }
    }
}
