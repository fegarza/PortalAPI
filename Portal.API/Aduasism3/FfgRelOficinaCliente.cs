using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffg_rel_oficina_cliente")]
    public partial class FfgRelOficinaCliente
    {
        [Key]
        [Column("id_oficina")]
        [StringLength(6)]
        public string IdOficina { get; set; }
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
    }
}
