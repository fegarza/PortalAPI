using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("gg_estado")]
    public partial class GgEstado
    {
        [Key]
        [Column("estado", TypeName = "decimal(2, 0)")]
        public decimal Estado { get; set; }
        [Column("nombre")]
        [StringLength(60)]
        public string Nombre { get; set; }
    }
}
