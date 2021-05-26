using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("gg_llaves")]
    public partial class GgLlafe
    {
        [Column("tabla")]
        [StringLength(100)]
        public string Tabla { get; set; }
        [Column("llaves")]
        [StringLength(255)]
        public string Llaves { get; set; }
    }
}
