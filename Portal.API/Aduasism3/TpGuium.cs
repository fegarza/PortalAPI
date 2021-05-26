using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("tp_guia")]
    public partial class TpGuium
    {
        [Key]
        [Column("id_pedimento")]
        public int IdPedimento { get; set; }
        [Key]
        [Column("id_guia")]
        public short IdGuia { get; set; }
        [Required]
        [Column("guia_manifiesto")]
        [StringLength(20)]
        public string GuiaManifiesto { get; set; }
        [Required]
        [Column("tipo_guia")]
        [StringLength(3)]
        public string TipoGuia { get; set; }
    }
}
