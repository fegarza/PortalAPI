using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("gg_ciudad")]
    public partial class GgCiudad
    {
        [Key]
        [Column("ciudad")]
        [StringLength(50)]
        public string Ciudad { get; set; }
        [Key]
        [Column("estado", TypeName = "decimal(2, 0)")]
        public decimal Estado { get; set; }
        [Column("nombre")]
        [StringLength(60)]
        public string Nombre { get; set; }
    }
}
