using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fequivalencia_cove_help")]
    public partial class FequivalenciaCoveHelp
    {
        [Key]
        [Column("id_unidad_universal")]
        [StringLength(5)]
        public string IdUnidadUniversal { get; set; }
        [Key]
        [Column("id_unidad_mexicana")]
        [StringLength(5)]
        public string IdUnidadMexicana { get; set; }
    }
}
