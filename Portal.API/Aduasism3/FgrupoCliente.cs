using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fgrupo_cliente")]
    public partial class FgrupoCliente
    {
        [Key]
        [Column("id_grupo")]
        [StringLength(10)]
        public string IdGrupo { get; set; }
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
    }
}
