using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("tp_contenedor")]
    public partial class TpContenedor
    {
        [Key]
        [Column("id_pedimento")]
        public int IdPedimento { get; set; }
        [Key]
        [Column("id_contenedor")]
        public short IdContenedor { get; set; }
        [Column("identificador")]
        public string Identificador { get; set; }
        [Column("tipo_contenedor")]
        public int? TipoContenedor { get; set; }
    }
}
