using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("mascaras_estructura")]
    public partial class MascarasEstructura
    {
        [Key]
        [Column("num_espacio")]
        public int NumEspacio { get; set; }
        [Key]
        [Column("atributo_name")]
        [StringLength(50)]
        public string AtributoName { get; set; }
        [Column("tipo_char")]
        public int TipoChar { get; set; }
        [Column("num_chars")]
        public int NumChars { get; set; }
    }
}
